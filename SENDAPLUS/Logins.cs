using MaterialSkin;
using MaterialSkin.Controls;
using MongoDB.Driver;
using System;
using System.Windows.Forms;


namespace SENDAPLUS
{
    public partial class FormLogin : MaterialForm
    {
        private MongoClient cliente;
        private IMongoDatabase db;
        private IMongoCollection<Usuarios> coleccionUsuarios;

        public FormLogin()
        {
            InitializeComponent();

            // MaterialSkin aqui se configura el tema y los colores de el formulario
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

            // Conexión Mongo
            cliente = new MongoClient("mongodb://localhost:27017");
            db = cliente.GetDatabase("SENDAPLUS");
            coleccionUsuarios = db.GetCollection<Usuarios>("usuarios");
        }

        private async void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim().ToLower();
            string password = txtContraseña.Text.Trim(); // el control puede llamarse así, pero el modelo usa Password

            // Validar campos vacíos
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }

            try
            {
                // Buscar usuario
                var filtro = Builders<Usuarios>.Filter.And(
                    Builders<Usuarios>.Filter.Eq(u => u.Correo, correo),
                    Builders<Usuarios>.Filter.Eq(u => u.Password, password)
                );

                var usuario = await coleccionUsuarios
                    .Find(filtro)
                    .FirstOrDefaultAsync();

                if (usuario == null)
                {
                    MessageBox.Show("Correo o contraseña incorrectos");
                    return;
                }

                // Redirección por rol
                if (usuario.Rol == "lider")
                {
                    MessageBox.Show("Bienvenido líder");
                    Lider frm = new Lider(usuario);
                    frm.Show();
                    this.Hide();
                }
                else if (usuario.Rol == "invitado")
                {
                    MessageBox.Show("Bienvenido invitado");
                    FormInvitado frm = new FormInvitado(usuario);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rol no reconocido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Desea salir de SENDAPLUS?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnmostrarEocultar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Password)
            {
                // Mostrar contraseña
                txtContraseña.Password = false;
            }
            else
            {
                // Ocultar contraseña
                txtContraseña.Password = true;
            }
        }
    }
}