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
        private Usuarios usuarioActual;
        // Conexión directa
        private ConexionMongo.Conectar conexion = new ConexionMongo.Conectar();

        // Variables para guardar lo que selecciones
        string idAprendiz = "";
        string idEvento = "";


        public Agrgar_invitados(Usuarios usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario; // Guardamos el usuario que mandó el Líder
        }

        private void Agrgar_invitados_Load(object sender, EventArgs e)
        {
            CargarTablas();

        }

        private void CargarTablas()
        {
            try
            {
                // 1. Forzar que las tablas creen sus propias columnas
                dgvAprendices.AutoGenerateColumns = true;
                dgvEventos.AutoGenerateColumns = true;

                // 2. Traer los datos de MongoDB
                var aprendices = conexion.Usuarios().Find(_ => true).ToList();
                var eventos = conexion.Eventos().Find(_ => true).ToList();

                // 3. Asignar los datos
                dgvAprendices.DataSource = aprendices;
                dgvEventos.DataSource = eventos;

                // 4. Agregar el cuadrito de Selección (Solo si no existe)
                if (!dgvAprendices.Columns.Contains("Seleccionar"))
                {
                    DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                    check.Name = "Seleccionar";
                    check.HeaderText = "Invitar";
                    dgvAprendices.Columns.Insert(0, check);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void btnAgregarSeleccionado_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarInvitacion_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idAprendiz) || string.IsNullOrEmpty(idEvento))
            {
                MessageBox.Show("Por favor, selecciona un Aprendiz y un Evento.");
                return;
            }

            try
            {
                var nuevaInv = new Invitacion
                {
                    IdEvento = idEvento,
                    IdInvitado = idAprendiz
                };

                conexion.Invitacion().InsertOne(nuevaInv);
                MessageBox.Show("¡Invitación guardada exitosamente!");

                // Limpiamos selección
                idAprendiz = ""; idEvento = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Este formulario normalmente se abre con ShowDialog(); Close() devuelve el control al llamador.
            this.Close();
        }

        private void Agrgar_invitados_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvSeleccionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInvitados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgveven_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSeleccionados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAprendices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Capturamos el ID de la primera celda (Id de Mongo)
                idAprendiz = dgvAprendices.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
            }
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEvento = dgvEventos.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
            }
        }

        private void Cargarbtn_Click(object sender, EventArgs e)
        {
            CargarTablas();
        }
    }
}
     