using MaterialSkin;
using MaterialSkin.Controls;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace SENDAPLUS
{
    public partial class Crear_Evento : MaterialForm
    {
        private readonly IMongoCollection<BsonDocument> _eventosCollection;
        private Usuarios _lider;
        private ObjectId _ultimoEventoId = ObjectId.Empty;
        private bool _modoConsulta = false;
        private bool _modoEdicion = false;
        private ObjectId _eventoEditId = ObjectId.Empty;
        private bool _isPopulating = false;
        private string _lblEstadoOriginalText;

        public Crear_Evento()
        {
            InitializeComponent();
            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
            msm.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.LightGreen200, TextShade.WHITE);

            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("SENDAPLUS");
            _eventosCollection = db.GetCollection<BsonDocument>("Evento");

            Load += Crear_Evento_Load;
        }

        public Crear_Evento(Usuarios lider) : this()
        {
            _lider = lider ?? throw new ArgumentNullException(nameof(lider));
            Text = $"CREAR EVENTO - {_lider.Nombre}";
        }

        public Crear_Evento(Usuarios lider, bool modoConsulta) : this(lider)
        {
            _modoConsulta = modoConsulta;
            if (_modoConsulta) SetConsultaMode();
        }

        private async void Crear_Evento_Load(object sender, EventArgs e)
        {
            _lblEstadoOriginalText = lblEstado?.Text ?? "Estado";
            txtconsultarevento.Visible = false;
            materialLabel1.Visible = false;

            // Sólo prevenir fechas pasadas en modo creación (no en consulta/edición)
            if (!_modoConsulta)
            {
                dateTimePicker1.MinDate = DateTime.Now;
                dateTimePicker2.MinDate = DateTime.Now;
                dateTimePicker1.Value = DateTime.Now.AddHours(1);
                dateTimePicker2.Value = DateTime.Now.AddHours(2);
            }

            AttachHandlers();

            if (!_modoConsulta)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                btnAgregarInvitados.Visible = false;
                btnGuardarevento.Enabled = false;
            }
            else
            {
                materialLabel1.Text = "Ingresa el nombre del evento:";
                materialLabel1.Visible = true;
                txtconsultarevento.Visible = true;
                txtconsultarevento.TextChanged -= Txtconsultarevento_TextChangedAsync;
                txtconsultarevento.TextChanged += Txtconsultarevento_TextChangedAsync;
            }

            dataGridView1.CellDoubleClick -= DataGridView1_CellDoubleClick;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;

            await CargarEventosEnGridAsync();
        }

        private void AttachHandlers()
        {
            materialTextBox1.TextChanged -= MaterialTextBox1_TextChanged;
            materialTextBox1.TextChanged += MaterialTextBox1_TextChanged;
            materialComboBox1.SelectedIndexChanged -= MaterialComboBox1_SelectedIndexChanged;
            materialComboBox1.SelectedIndexChanged += MaterialComboBox1_SelectedIndexChanged;
            dateTimePicker1.ValueChanged -= DateTimePicker1_ValueChanged;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged -= DateTimePicker2_ValueChanged;
            dateTimePicker2.ValueChanged += DateTimePicker2_ValueChanged;
        }

        private void MaterialTextBox1_TextChanged(object s, EventArgs e) => ValidateFormState();
        private void MaterialComboBox1_SelectedIndexChanged(object s, EventArgs e) => ValidateFormState();
        private void DateTimePicker1_ValueChanged(object s, EventArgs e) => _ = DateTimePicker_ValueChangedAsync();
        private void DateTimePicker2_ValueChanged(object s, EventArgs e) => ValidateDateTime();

        private void SetConsultaMode()
        {
            _modoConsulta = true;
            lblNombredelevento.Visible = false; materialTextBox1.Visible = false;
            lblTipodeevento.Visible = false; materialComboBox1.Visible = false;
            lblFechayhoradeinicio.Visible = false; dateTimePicker1.Visible = false;
            lblFechayhorafin.Visible = false; dateTimePicker2.Visible = false;
            lblEstado.Visible = true; materialComboBox2.Visible = false;
            txtLugar.Visible = false;
            materialComboBox2.Visible = false;
            txtconsultarevento.Visible = true; materialLabel1.Visible = true;
            btnGuardarevento.Visible = false; btnAgregarInvitados.Visible = false;
            dataGridView1.Visible = true; btActualizarEvento.Visible = true;
            Text = "CONSULTAR EVENTOS";
        }

        private void ValidateFormState()
        {
            if (_isPopulating) return;
            bool tieneNombre = !string.IsNullOrWhiteSpace(materialTextBox1.Text);
            bool tieneTipo = materialComboBox1.SelectedItem != null;
            dateTimePicker1.Enabled = dateTimePicker2.Enabled = tieneNombre && tieneTipo;
            btnGuardarevento.Enabled = tieneNombre && tieneTipo && dateTimePicker1.Enabled && !IsFechaInicioEnPasado();
        }

        private void ValidateDateTime()
        {
            if (_isPopulating) return;
            if (dateTimePicker2.Value <= dateTimePicker1.Value) dateTimePicker2.Value = dateTimePicker1.Value.AddHours(1);
            ValidateFormState();
        }

        private bool IsFechaInicioEnPasado() => dateTimePicker1.Value < DateTime.Now;

        private async Task DateTimePicker_ValueChangedAsync()
        {
            if (_isPopulating) return;
            if (IsFechaInicioEnPasado())
            {
                MessageBox.Show("La fecha y hora de inicio no pueden estar en el pasado.");
                dateTimePicker1.Value = DateTime.Now.AddHours(1);
                return;
            }
            ValidateDateTime();
            await ValidarConflictoFechaHoraAsync();
        }

        private FilterDefinition<BsonDocument> BuildFechaHoraFilter(DateTime fecha, string hora, bool excludeCurrent = false)
        {
            var f = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("fecha", fecha),
                Builders<BsonDocument>.Filter.Eq("hora", hora),
                Builders<BsonDocument>.Filter.Ne("estado", "desactivado")
            );
            if (excludeCurrent && _modoEdicion && _eventoEditId != ObjectId.Empty)
                f = Builders<BsonDocument>.Filter.And(f, Builders<BsonDocument>.Filter.Ne("_id", _eventoEditId));
            return f;
        }

        private async Task<bool> ConflictoFechaHoraExisteAsync(DateTime fecha, string hora, bool excludeCurrent = false)
        {
            var filtro = BuildFechaHoraFilter(fecha, hora, excludeCurrent);
            var existe = await _eventosCollection.Find(filtro).FirstOrDefaultAsync();
            return existe != null;
        }

        private async Task ValidarConflictoFechaHoraAsync()
        {
            if (_isPopulating) return;
            var fecha = dateTimePicker1.Value.Date;
            var hora = dateTimePicker1.Value.ToString("HH:mm");
            var existe = await ConflictoFechaHoraExisteAsync(fecha, hora, excludeCurrent: _modoEdicion);
            if (existe)
            {
                lblEstado.Text = "Conflicto: ya existe un evento en esa fecha y hora.";
                lblEstado.ForeColor = Color.Red; btnGuardarevento.Enabled = false;
            }
            else
            {
                lblEstado.Text = _lblEstadoOriginalText ?? "Estado";
                lblEstado.ForeColor = Color.Black;
                ValidateFormState();
            }
        }

        private async Task<ObjectId?> GuardarEventoAsync()
        {
            if (_lider == null) { MessageBox.Show("Inicia sesión como líder para crear eventos."); return null; }
            string nombre = materialTextBox1.Text?.Trim();
            string tipo = materialComboBox1.SelectedItem?.ToString();
            DateTime inicio = dateTimePicker1.Value;
            DateTime fin = dateTimePicker2.Value;
            string lugar = txtLugar.Text?.Trim() ?? "";
            string estado = materialComboBox2.SelectedItem?.ToString() ?? "activo";

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo)) { MessageBox.Show("Completa nombre y tipo antes de guardar."); return null; }
            if (inicio < DateTime.Now && !_modoEdicion) { MessageBox.Show("La fecha y hora de inicio no pueden estar en el pasado."); return null; }
            if (fin <= inicio) { MessageBox.Show("La fecha y hora de fin debe ser posterior a la fecha y hora de inicio."); return null; }

            var fecha = inicio.Date;
            var hora = inicio.ToString("HH:mm");

            // Conflicto día del líder
            var filtroDiaLider = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("liderCorreo", _lider.Correo),
                Builders<BsonDocument>.Filter.Gte("fecha", fecha),
                Builders<BsonDocument>.Filter.Lt("fecha", fecha.AddDays(1)),
                Builders<BsonDocument>.Filter.Ne("estado", "desactivado")
            );
            if (_modoEdicion && _eventoEditId != ObjectId.Empty)
                filtroDiaLider = Builders<BsonDocument>.Filter.And(filtroDiaLider, Builders<BsonDocument>.Filter.Ne("_id", _eventoEditId));

            if (await _eventosCollection.Find(filtroDiaLider).FirstOrDefaultAsync() != null)
            {
                MessageBox.Show("Ya existe un evento programado para este líder en el mismo día.");
                return null;
            }

            if (await ConflictoFechaHoraExisteAsync(fecha, hora, excludeCurrent: _modoEdicion))
            {
                MessageBox.Show("Ya existe un evento en la misma fecha y hora.");
                return null;
            }

            if (_modoEdicion && _eventoEditId != ObjectId.Empty)
            {
                var filtroId = Builders<BsonDocument>.Filter.Eq("_id", _eventoEditId);
                var update = Builders<BsonDocument>.Update
                    .Set("nombreEvento", nombre)
                    .Set("tipoEvento", tipo)
                    .Set("fecha", fecha)
                    .Set("hora", hora)
                    .Set("lugar", lugar)
                    .Set("estado", estado.ToLower())
                    .Set("liderCorreo", _lider.Correo);

                var result = await _eventosCollection.UpdateOneAsync(filtroId, update);
                if (result.ModifiedCount > 0) MessageBox.Show("Evento actualizado correctamente."); else MessageBox.Show("No se realizó ninguna modificación.");
                _modoEdicion = false; _eventoEditId = ObjectId.Empty; btnGuardarevento.Text = "Guardar evento";
            }
            else
            {
                var id = ObjectId.GenerateNewId();
                var documento = new BsonDocument
                {
                    { "_id", id },
                    { "nombreEvento", nombre },
                    { "tipoEvento", tipo },
                    { "fecha", fecha },
                    { "hora", hora },
                    { "lugar", lugar },
                    { "estado", estado.ToLower() },
                    { "liderCorreo", _lider.Correo }
                };
                await _eventosCollection.InsertOneAsync(documento);
                MessageBox.Show("Evento guardado correctamente.");
                _ultimoEventoId = id;
            }

            await CargarEventosEnGridAsync();
            return _ultimoEventoId != ObjectId.Empty ? (ObjectId?)_ultimoEventoId : null;
        }

        private async Task CargarEventosEnGridAsync(FilterDefinition<BsonDocument> filtro = null)
        {
            var f = filtro ?? Builders<BsonDocument>.Filter.Empty;
            if (dataGridView1.InvokeRequired) { dataGridView1.BeginInvoke(new Action(async () => await CargarEventosEnGridAsync(f))); return; }

            int intentos = 2;
            while (intentos-- > 0)
            {
                try
                {
                    dataGridView1.SuspendLayout();
                    var modoPrevio = dataGridView1.AutoSizeColumnsMode;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dataGridView1.Rows.Clear();
                    var lista = await _eventosCollection.Find(f).ToListAsync();
                    foreach (var e in lista)
                    {
                        var id = e.Contains("_id") ? e["_id"].ToString() : "";
                        var nombre = e.Contains("nombreEvento") ? e["nombreEvento"].AsString : "";
                        var tipo = e.Contains("tipoEvento") ? e["tipoEvento"].AsString : "";
                        var fecha = e.Contains("fecha") ? e["fecha"].ToLocalTime().ToString("dd/MM/yyyy") : "";
                        var hora = e.Contains("hora") ? e["hora"].AsString : "";
                        var lugar = e.Contains("lugar") ? e["lugar"].AsString : "";
                        var estado = e.Contains("estado") ? e["estado"].AsString : "";
                        dataGridView1.Rows.Add(id, nombre, tipo, fecha, hora, lugar, estado);
                    }
                    dataGridView1.AutoSizeColumnsMode = modoPrevio;
                    dataGridView1.ResumeLayout();
                    break;
                }
                catch (InvalidOperationException)
                {
                    if (intentos <= 0) throw;
                    await Task.Delay(50);
                }
                finally { try { if (!dataGridView1.IsDisposed) dataGridView1.ResumeLayout(); } catch { } }
            }

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        // Helper seguro para asignar Value incluso si MinDate impediría la asignación
        private void SetPickerValueSafely(DateTimePicker picker, DateTime value)
        {
            var prevMin = picker.MinDate;
            try
            {
                picker.MinDate = DateTimePicker.MinimumDateTime;
                if (value < DateTimePicker.MinimumDateTime) value = DateTimePicker.MinimumDateTime;
                if (value > DateTimePicker.MaximumDateTime) value = DateTimePicker.MaximumDateTime;
                picker.Value = value;
            }
            finally { picker.MinDate = prevMin; }
        }

        // Cargar seleccionado para edición (usado por botón actualizar)
        private async void btActualizarEvento_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null || dataGridView1.SelectedRows.Count == 0) { MessageBox.Show("Selecciona un evento en la tabla para editar."); return; }
            var idCell = dataGridView1.SelectedRows[0].Cells["ID"].Value;
            if (idCell == null || !ObjectId.TryParse(idCell.ToString(), out ObjectId eventoId)) { MessageBox.Show("ID de evento inválido o no disponible."); return; }

            var documento = await _eventosCollection.Find(Builders<BsonDocument>.Filter.Eq("_id", eventoId)).FirstOrDefaultAsync();
            if (documento == null) { MessageBox.Show("Evento no encontrado en la base de datos."); return; }

            _isPopulating = true;
            PopulateControls(documento);
            _modoEdicion = true;
            _eventoEditId = eventoId;

            lblNombredelevento.Visible = materialTextBox1.Visible = true;
            lblTipodeevento.Visible = materialComboBox1.Visible = true;
            lblFechayhoradeinicio.Visible = dateTimePicker1.Visible = true;
            lblFechayhorafin.Visible = dateTimePicker2.Visible = true;
            lblEstado.Visible = materialComboBox2.Visible = txtLugar.Visible = true;
            btnGuardarevento.Visible = true; btnGuardarevento.Text = "Actualizar evento"; btnAgregarInvitados.Visible = false;

            _isPopulating = false;
        }

        // Poblado centralizado
        private void PopulateControls(BsonDocument doc)
        {
            materialTextBox1.Text = doc.Contains("nombreEvento") ? doc["nombreEvento"].AsString : "";
            var tipo = doc.Contains("tipoEvento") ? doc["tipoEvento"].AsString : "";
            for (int i = 0; i < materialComboBox1.Items.Count; i++)
                if (materialComboBox1.Items[i].ToString().Equals(tipo, StringComparison.OrdinalIgnoreCase)) { materialComboBox1.SelectedIndex = i; break; }

            DateTime fecha = doc.Contains("fecha") ? doc["fecha"].ToLocalTime().Date : DateTime.Now.Date;
            string hora = doc.Contains("hora") ? doc["hora"].AsString : "09:00";

            if (!TimeSpan.TryParse(hora, out TimeSpan ts)) ts = TimeSpan.FromHours(9);
            var desiredStart = fecha.Add(ts);
            SetPickerValueSafely(dateTimePicker1, desiredStart);
            SetPickerValueSafely(dateTimePicker2, dateTimePicker1.Value.AddHours(1));

            txtLugar.Text = doc.Contains("lugar") ? doc["lugar"].AsString : "";
            var estado = doc.Contains("estado") ? doc["estado"].AsString : "activo";
            for (int i = 0; i < materialComboBox2.Items.Count; i++)
                if (materialComboBox2.Items[i].ToString().Equals(estado, StringComparison.OrdinalIgnoreCase)) { materialComboBox2.SelectedIndex = i; break; }
        }

        private async void Txtconsultarevento_TextChangedAsync(object s, EventArgs e) => await BuscarEventosPorNombreAsync(txtconsultarevento.Text.Trim());
        private async Task BuscarEventosPorNombreAsync(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) { await CargarEventosEnGridAsync(); return; }
            var regex = new BsonRegularExpression(texto, "i");
            var filtro = Builders<BsonDocument>.Filter.Regex("nombreEvento", regex);
            await CargarEventosEnGridAsync(filtro);
        }

        private async void btnAgregarInvitados_Click(object sender, EventArgs e)
        {
            if (_ultimoEventoId == ObjectId.Empty)
            {
                var id = await GuardarEventoAsync();
                if (id == null) return;
            }

            DateTime inicio = dateTimePicker1.Value;
            DateTime fecha = inicio.Date;
            string hora = inicio.ToString("HH:mm");

            var frm = new Agrgar_invitados(_ultimoEventoId, fecha, hora);
            frm.ShowDialog();
            await CargarEventosEnGridAsync();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (_lider != null) new Lider(_lider).Show(); else new FormLogin().Show();
            }
            finally { Close(); }
        }

        // Doble clic en la grilla muestra detalles (modo consulta)
        private async void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var idCell = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
            if (idCell == null || !ObjectId.TryParse(idCell.ToString(), out ObjectId eventoId)) { MessageBox.Show("ID de evento inválido."); return; }

            var doc = await _eventosCollection.Find(Builders<BsonDocument>.Filter.Eq("_id", eventoId)).FirstOrDefaultAsync();
            if (doc == null) { MessageBox.Show("Evento no encontrado."); return; }

            var nombre = doc.Contains("nombreEvento") ? doc["nombreEvento"].AsString : "";
            var tipo = doc.Contains("tipoEvento") ? doc["tipoEvento"].AsString : "";
            var fecha = doc.Contains("fecha") ? doc["fecha"].ToLocalTime().ToString("dd/MM/yyyy") : "";
            var hora = doc.Contains("hora") ? doc["hora"].AsString : "";
            var lugar = doc.Contains("lugar") ? doc["lugar"].AsString : "";
            var estado = doc.Contains("estado") ? doc["estado"].AsString : "";
            var lider = doc.Contains("liderCorreo") ? doc["liderCorreo"].AsString : "";

            var texto = $"Nombre: {nombre}\nTipo: {tipo}\nFecha: {fecha}\nHora: {hora}\nLugar: {lugar}\nEstado: {estado}\nLíder: {lider}";
            MessageBox.Show(texto, "Detalles del evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnGuardarevento_Click(object sender, EventArgs e)
        {
            await GuardarEventoAsync();
        }
    }
}