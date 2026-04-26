using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SENDAPLUS
{
    public partial class FormREGISTRO : Form
    {
        public FormREGISTRO()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // validar botones que no esten vacios 
            if (txtnombre.Text.Trim() ==  "" || txtcorreo.Text.Trim() == ""
                || txtconraseña.Text.Trim() == "" || txtnumerodedocumento.Text.Trim() == "" || txtrol.Text.Trim() == "")

        
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            
            }

            string nombre = txtnombre.Text.Trim();
            string correo = txtcorreo.Text.Trim().ToLower();
            string password = txtconraseña.Text.Trim();
            string documento = txtnumerodedocumento.Text.Trim();

            if (!int.TryParse(documento, out int doc))
            {
                MessageBox.Show("El número de documento debe ser numérico");
                return;
            }

            // Validación básica
            if (string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(correo) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

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

                // 💾 GUARDAR
                await coleccion.InsertOneAsync(nuevo);

                MessageBox.Show("Usuario registrado correctamente");

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
}
}
