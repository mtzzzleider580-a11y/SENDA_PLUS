using MaterialSkin;
using MaterialSkin.Controls;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SENDAPLUS
{
    public partial class FormREGISTRO : MaterialForm
    {
        public FormREGISTRO()
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





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
       //private void button1_Click(object sender, EventArgs e)
       // {
           
        //}

       // private async void button2_Click(object sender, EventArgs e)
       // {
          
       // }

        private void FormREGISTRO_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿desea volver al inicio?", "VOLVER", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                FormLogin log = new FormLogin();
                log.Show();
                this.Hide();
            }


        }

        private async void Button2_Click_1(object sender, EventArgs e)
        {
            // validar botones que no esten vacios 
            if (txtnombre.Text.Trim() == "" || txtcorreo.Text.Trim() == ""
                || txtcontraseña.Text.Trim() == "" || txtnumerodedocumento.Text.Trim() == "")


            {
                MessageBox.Show("Debe llenar todos los campos");
                return;

            }

            // aqui creo las variables y convierto las cajas de texto 

            string nombre = txtnombre.Text.Trim();
            string correo = txtcorreo.Text.Trim().ToLower();
            string password = txtcontraseña.Text.Trim();
            string documento = txtnumerodedocumento.Text.Trim();

            string patron = @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{5,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, patron))
            {
                MessageBox.Show("La contraseña debe tener mínimo 5 caracteres y contener letras, números y un signo.");
                return;
            }



            // hago las validaciones para registro 

            // si correo no lleva aroba error 
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("El correo no es válido");
                return;
            }

            // numero de documento tiene que ser numero 
            if (!int.TryParse(documento, out int doc))
            {
                MessageBox.Show("El número de documento debe ser numérico");
                return;
            }

            // validacion contraseña
            

            try
            {
                var conexion = new ConexionMongo.Conectar();
                var coleccion = conexion.Usuarios();

                //  VALIDAR CORREO
                var existeCorreo = await coleccion
                    .Find(u => u.Correo == correo)
                    .FirstOrDefaultAsync();

                if (existeCorreo != null)
                {
                    MessageBox.Show("El correo ya está registrado");
                    return;
                }

                //  VALIDAR CÉDULA
                var existeCedula = await coleccion
                    .Find(u => u.NumeroDocumento == doc)
                    .FirstOrDefaultAsync();

                if (existeCedula != null)
                {
                    MessageBox.Show("La cédula ya está registrada");
                    return;
                }

                //  CREAR USUARIO
                Usuarios nuevo = new Usuarios
                {
                    Nombre = nombre,
                    Correo = correo,
                    Password = password,
                    NumeroDocumento = doc,
                    Rol = "invitado" //  FIJO
                };

                //  GUARDAR
                await coleccion.InsertOneAsync(nuevo);

                MessageBox.Show("Usuario registrado correctamente");

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
