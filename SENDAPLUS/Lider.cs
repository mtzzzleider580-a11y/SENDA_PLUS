using MaterialSkin.Controls;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Windows.Forms;


namespace SENDAPLUS
{
    public partial class Lider : MaterialForm
    {
        private readonly Usuarios usuarioActual;
        private readonly IMongoCollection<BsonDocument> _eventosCollection;

        public Lider(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));

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
    }
}