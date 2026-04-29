using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MongoDB.Driver;

namespace SENDAPLUS
{
    public partial class Crear_Evento : MaterialForm
    {
        private readonly IMongoCollection<Usuarios> _usuariosCollection;
        private readonly List<Usuarios> _invitados = new List<Usuarios>();
        private readonly List<Usuarios> _seleccionados = new List<Usuarios>();

        public Crear_Evento()
        {
            InitializeComponent();

            // Configurar MaterialSkin coherente con el resto del proyecto
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700, Primary.Blue200,
                Accent.LightBlue200, TextShade.WHITE);

            // Instancia de conexión a Mongo (clase en tu proyecto: ConexionMongo.Conectar)
            var conexion = new ConexionMongo.Conectar();
            _usuariosCollection = conexion.Usuarios();

            // Asociar eventos (además del que ya genera el Designer)
            this.Load += Crear_Evento_Load;
            btnAgregarInvitados.Click += BtnAgregarInvitados_Click;
            btnAgregarSeleccionado.Click += BtnAgregarSeleccionado_Click;
            btnQuitarInvitacion.Click += BtnQuitarInvitacion_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelarEvento.Click += BtnCancelarEvento_Click;
            btnVolver.Click += BtnVolver_Click;
        }

        private async void Crear_Evento_Load(object sender, EventArgs e)
        {
            await CargarInvitadosAsync();
        }

        private async Task CargarInvitadosAsync()
        {
            try
            {
                // Ajusta el filtro según tu modelo; aquí se asume Rol == "invitado"
                var lista = await _usuariosCollection.Find(u => u.Rol == "invitado").ToListAsync();

                _invitados.Clear();
                _invitados.AddRange(lista);

                dgvInvitados.Rows.Clear();
                foreach (var u in _invitados)
                {
                    // Asegúrate de que el dgvInvitados tiene exactamente 4 columnas: Id, Nombre, Correo, Seleccionar
                    dgvInvitados.Rows.Add(u.Id, u.Nombre, u.Correo, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar invitados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manejador referenciado por el Designer; mantener la firma exacta
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Ejemplo: asegurarse que la fecha fin no sea anterior a la de inicio
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value.AddHours(1);
            }
        }

        private void BtnAgregarInvitados_Click(object sender, EventArgs e)
        {
            // Abrir formulario de registro para crear nuevos usuarios/invitados.
            using (var reg = new FormREGISTRO())
            {
                reg.ShowDialog();
            }

            // Recargar la lista de invitados (fire-and-forget)
            _ = CargarInvitadosAsync();
        }

        private void BtnAgregarSeleccionado_Click(object sender, EventArgs e)
        {
            // Mover filas marcadas en dgvInvitados a dgvSeleccionados
            for (int i = dgvInvitados.Rows.Count - 1; i >= 0; i--)
            {
                var row = dgvInvitados.Rows[i];
                if (row.IsNewRow) continue;

                bool marcado = false;
                var cell = row.Cells["Seleccionar"];
                if (cell != null && cell.Value != null)
                {
                    bool.TryParse(cell.Value.ToString(), out marcado);
                }

                if (marcado)
                {
                    string id = row.Cells["Id"].Value?.ToString();
                    string nombre = row.Cells["Nombre"].Value?.ToString();
                    string correo = row.Cells["Correo"].Value?.ToString();

                    // Evitar duplicados en seleccionados
                    if (!_seleccionados.Any(s => s.Correo == correo))
                    {
                        _seleccionados.Add(new Usuarios { Id = id, Nombre = nombre, Correo = correo });
                        // dgvSeleccionados tiene 3 columnas: id(hidden), Nombre, Correo
                        dgvSeleccionados.Rows.Add(id, nombre, correo);
                    }

                    // Quitar de invitados (interfaz)
                    dgvInvitados.Rows.RemoveAt(i);

                    // Quitar también de la lista interna
                    var toRemove = _invitados.FirstOrDefault(x => x.Id == id);
                    if (toRemove != null) _invitados.Remove(toRemove);
                }
            }
        }

        private void BtnQuitarInvitacion_Click(object sender, EventArgs e)
        {
            // Quitar filas seleccionadas de dgvSeleccionados y devolverlas a dgvInvitados
            if (dgvSeleccionados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione las filas a quitar en la lista de seleccionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow sel in dgvSeleccionados.SelectedRows)
            {
                if (sel.IsNewRow) continue;

                string id = sel.Cells[0].Value?.ToString();
                string nombre = sel.Cells[1].Value?.ToString();
                string correo = sel.Cells[2].Value?.ToString();

                // Devolver a invitables si no existe ya
                if (!_invitados.Any(x => x.Correo == correo))
                {
                    _invitados.Add(new Usuarios { Id = id, Nombre = nombre, Correo = correo });
                    dgvInvitados.Rows.Add(id, nombre, correo, false);
                }

                _seleccionados.RemoveAll(s => s.Correo == correo);
                dgvSeleccionados.Rows.Remove(sel);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            string nombreEvento = materialTextBox1.Text?.Trim() ?? "";
            if (string.IsNullOrEmpty(nombreEvento))
            {
                MessageBox.Show("Ingrese el nombre del evento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime inicio = dateTimePicker1.Value;
            DateTime fin = dateTimePicker2.Value;
            if (fin <= inicio)
            {
                MessageBox.Show("La fecha/hora fin debe ser posterior a la de inicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_seleccionados.Count == 0)
            {
                MessageBox.Show("Agregue al menos un invitado al evento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Resumen (aquí puedes persistir el evento en BD)
            var tipoEvento = materialComboBox1.SelectedItem?.ToString() ?? "(no seleccionado)";
            string resumen = $"Evento: {nombreEvento}\r\nTipo: {tipoEvento}\r\nInicio: {inicio}\r\nFin: {fin}\r\nInvitados: {string.Join(", ", _seleccionados.Select(s => s.Correo))}";
            MessageBox.Show(resumen, "Resumen del evento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: Persistir en MongoDB usando las colecciones Eventos/Invitacion si implementas las clases correspondientes
        }

        private void BtnCancelarEvento_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("¿Desea cancelar la creación del evento?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK) this.Close();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}