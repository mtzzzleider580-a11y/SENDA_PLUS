using MaterialSkin.Controls;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace SENDAPLUS
{
    public partial class Lider : MaterialForm
    {
        private Usuarios usuarioActual;
        private IMongoCollection<BsonDocument> _eventosCollection;

        public Lider()
        {
            InitializeComponent();
        }

        public Lider(Usuarios usuario) : this()
        {
            usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));
            InicializarRuntime();
        }

        private void InicializarRuntime()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            // Mostrar nombre del líder en el label
            label1.Text = usuarioActual.Nombre;

            // Inicializar conexión a MongoDB
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("SENDAPLUS");
            _eventosCollection = db.GetCollection<BsonDocument>("Evento");
        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {

            Crear_Evento cra = new Crear_Evento(usuarioActual);
            cra.Show();
            this.Hide();
        }

        private void btnConsultarEvento_Click(object sender, EventArgs e)
        {
            var frm = new Crear_Evento(usuarioActual);
            frm.Show();
            this.Hide();
        }

        private void btnActualizarEventos_Click(object sender, EventArgs e)
        {
            var frm = new Crear_Evento(usuarioActual);
            frm.Show();
            this.Hide();

        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
            }
        }

        private void Lider_Load(object sender, EventArgs e)
        {

        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            // Pasamos 'usuarioActual' que es el que ya tienes en este formulario
            Agrgar_invitados agr = new Agrgar_invitados(usuarioActual);
            agr.Show();
            this.Hide(); // Usamos Hide para que el Menú Líder no se cierre del todo 
        }
    }
}