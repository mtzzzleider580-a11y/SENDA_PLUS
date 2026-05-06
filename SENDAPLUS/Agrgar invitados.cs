using MaterialSkin;
using MaterialSkin.Controls;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SENDAPLUS
{
    public partial class Agrgar_invitados : MaterialForm
    {
        private readonly IMongoCollection<Usuarios> _usuariosCollection;
        private readonly IMongoCollection<BsonDocument> _invitacionCollection;
        private readonly IMongoCollection<BsonDocument> _eventoCollection;

        private ObjectId _eventoId = ObjectId.Empty;
        private DateTime _fechaEvento;
        private string _horaEvento;

        // Constructor sin parámetros para diseñador
        public Agrgar_invitados()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green600,
                Primary.Green700,
                Primary.Green200,
                Accent.LightGreen200,
                TextShade.WHITE
            );

            var conexion = new ConexionMongo.Conectar();
            _usuariosCollection = conexion.Usuarios();

            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("SENDAPLUS");
            _invitacionCollection = db.GetCollection<BsonDocument>("Invitacion");
            _eventoCollection = db.GetCollection<BsonDocument>("Evento");

            Load += Agrgar_invitados_Load;
        }

        // Constructor real usado en ejecución
        public Agrgar_invitados(ObjectId eventoId, DateTime fechaEvento, string horaEvento) : this()
        {
            _eventoId = eventoId;
            _fechaEvento = fechaEvento;
            _horaEvento = horaEvento;
            this.Text = $"AGREGAR INVITADOS - Evento {_eventoId}";
        }

        private async void Agrgar_invitados_Load(object sender, EventArgs e)
        {
            await CargarInvitadosAsync();
        }

        private async Task CargarInvitadosAsync()
        {
            dgvInvitados.Rows.Clear();

            var lista = await _usuariosCollection.Find(Builders<Usuarios>.Filter.Empty).ToListAsync();
            foreach (var u in lista)
            {
                var id = u.GetType().GetProperty("Id")?.GetValue(u)?.ToString() ?? "";
                dgvInvitados.Rows.Add(id, u.Nombre, u.Correo, false);
            }
        }

        private void btnAgregarSeleccionado_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInvitados.Rows)
            {
                bool seleccionado = row.Cells["Seleccionar"].Value != null && (bool)row.Cells["Seleccionar"].Value;
                if (!seleccionado) continue;

                string id = row.Cells["Id"].Value?.ToString() ?? "";
                string nombre = row.Cells["Nombre"].Value?.ToString() ?? "";
                string correo = row.Cells["Correo"].Value?.ToString() ?? "";

                bool existe = dgvSeleccionados.Rows.Cast<DataGridViewRow>()
                    .Any(r => (r.Cells["dataGridViewTextBoxColumn2"].Value?.ToString() ?? "") == nombre &&
                              (r.Cells["dataGridViewTextBoxColumn3"].Value?.ToString() ?? "") == correo);

                if (!existe)
                {
                    dgvSeleccionados.Rows.Add(id, nombre, correo);
                }
            }
        }

        private void btnQuitarInvitacion_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSeleccionados.SelectedRows)
            {
                dgvSeleccionados.Rows.Remove(row);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_eventoId == ObjectId.Empty)
            {
                MessageBox.Show("Evento inválido. Asegúrate de crear o seleccionar un evento primero.");
                return;
            }

            if (dgvSeleccionados.Rows.Count == 0)
            {
                MessageBox.Show("No hay invitados seleccionados.");
                return;
            }

            int guardados = 0;

            foreach (DataGridViewRow row in dgvSeleccionados.Rows)
            {
                string invitadoIdStr = row.Cells[0].Value?.ToString() ?? "";
                string invitadoNombre = row.Cells[1].Value?.ToString() ?? "";
                string invitadoCorreo = row.Cells[2].Value?.ToString() ?? "";

                if (!ObjectId.TryParse(invitadoIdStr, out ObjectId invitadoId))
                {
                    var u = await _usuariosCollection.Find(Builders<Usuarios>.Filter.Eq("correo", invitadoCorreo)).FirstOrDefaultAsync();
                    if (u == null)
                    {
                        MessageBox.Show($"No se encontró el usuario {invitadoNombre} ({invitadoCorreo}).");
                        continue;
                    }
                    var prop = u.GetType().GetProperty("Id")?.GetValue(u);
                    invitadoId = prop is ObjectId oid ? oid : (prop != null ? ObjectId.Parse(prop.ToString()) : ObjectId.Empty);
                }

                // Buscar invitaciones previas del invitado y comparar fecha/hora con el evento actual
                var filtroInvitado = Builders<BsonDocument>.Filter.Eq("idInvitado", invitadoId);
                var invitaciones = await _invitacionCollection.Find(filtroInvitado).ToListAsync();

                bool conflicto = false;
                foreach (var inv in invitaciones)
                {
                    if (!inv.Contains("idEvento")) continue;
                    var idEv = inv["idEvento"].AsObjectId;
                    var ev = await _eventoCollection.Find(Builders<BsonDocument>.Filter.Eq("_id", idEv)).FirstOrDefaultAsync();
                    if (ev == null) continue;
                    DateTime fechaEv = ev.Contains("fecha") ? ev["fecha"].ToUniversalTime().ToLocalTime().Date : DateTime.MinValue;
                    string horaEv = ev.Contains("hora") ? ev["hora"].AsString : "";

                    if (fechaEv == _fechaEvento.Date && horaEv == _horaEvento)
                    {
                        conflicto = true;
                        break;
                    }
                }

                if (conflicto)
                {
                    MessageBox.Show($"El invitado {invitadoNombre} ({invitadoCorreo}) ya tiene una invitación en la misma fecha y hora.");
                    continue;
                }

                var docInv = new BsonDocument
                {
                    { "_id", ObjectId.GenerateNewId() },
                    { "idEvento", _eventoId },
                    { "idInvitado", invitadoId }
                };

                await _invitacionCollection.InsertOneAsync(docInv);
                guardados++;
            }

            MessageBox.Show($"Invitaciones guardadas: {guardados}.");
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Este formulario normalmente se abre con ShowDialog(); Close() devuelve el control al llamador.
            this.Close();
        }   
    }
}