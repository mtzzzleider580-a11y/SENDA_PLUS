using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MongoDB.Driver;


namespace SENDAPLUS
{
    public partial class FormInvitado : MaterialForm
    {

        private Usuarios usuarioActual;
        private ConexionMongo.Conectar conexion = new ConexionMongo.Conectar();

        public FormInvitado(Usuarios usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            label1.Text = "Bienvenido, " + usuarioActual.Nombre; // Personalizamos el saludo
        }


        private  void FormInvitado_Load(object sender, EventArgs e)
        { 

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private  void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;

                // 1. Buscar invitaciones del usuario logueado
                var misInvitaciones = conexion.Invitacion()
                    .Find(x => x.IdInvitado == usuarioActual.Id)
                    .ToList();

                // 2. Obtener IDs de eventos
                var idsEventos = misInvitaciones
                    .Select(x => x.IdEvento)
                    .ToList();

                // 3. Buscar eventos relacionados
                var eventos = conexion.Eventos()
                    .Find(x => idsEventos.Contains(x.Id))
                    .ToList();

                // 4. Mostrar en tabla
                dataGridView1.DataSource = eventos;

                if (eventos.Count == 0)
                {
                    MessageBox.Show("No tienes invitaciones.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // no se usa 
        private void btnDetalles_Click(object sender, EventArgs e)
        {
        }

        private  void btnfiltrar_Click(object sender, EventArgs e)
        {

            if (cmbMes.SelectedIndex == -1) return;

            int mesBuscado = cmbMes.SelectedIndex + 1; // Enero es 0, por eso +1

            // Obtenemos lo que ya está en la tabla y lo filtramos
            var listaActual = (List<Evento>)dataGridView1.DataSource;
            if (listaActual != null)
            {
                var filtrados = listaActual.Where(x => x.Fecha.Month == mesBuscado).ToList();
                dataGridView1.DataSource = filtrados;
            }

        }

        private void btnCerrarsesión_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();

                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
