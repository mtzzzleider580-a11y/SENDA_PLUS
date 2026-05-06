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
        // Colecciones de Mongo
        private IMongoCollection<Invitacion> colInvitaciones;
        private IMongoCollection<Evento> colEventos;

        public FormInvitado(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

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
            var conexion = new ConexionMongo.Conectar();

            colInvitaciones = conexion.Invitacion();
            colEventos = conexion.Eventos();
        }

        private async Task CargarEventosAsignados()
        {
            try
            {
                // 1. Buscar invitaciones del usuario
                var invitaciones = await colInvitaciones
                    .Find(i => i.IdInvitado == usuarioActual.Id)
                    .ToListAsync();

                if (invitaciones.Count == 0)
                {
                    MessageBox.Show("No tienes eventos asignados");
                    dataGridView1.DataSource = null;
                    return;
                }

                // 2. Obtener IDs de eventos
                var idsEventos = invitaciones.Select(i => i.IdEvento).ToList();

                // 3. Buscar eventos en la colección
                var eventos = await colEventos
                    .Find(e => idsEventos.Contains(e.Id))
                    .ToListAsync();

                // 4. Mostrar en el DataGridView
                dataGridView1.DataSource = eventos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarMeses()
        {
            cmbMes.Items.Add("Enero");
            cmbMes.Items.Add("Febrero");
            cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril");
            cmbMes.Items.Add("Mayo");
            cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("Julio");
            cmbMes.Items.Add("Agosto");
            cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre");
            cmbMes.Items.Add("Noviembre");
            cmbMes.Items.Add("Diciembre");
        }

        private async void FormInvitado_Load(object sender, EventArgs e)
        { // Mostrar nombre del usuario
            label1.Text = "Bienvenido " + usuarioActual.Nombre;

            // Cargar eventos automáticamente
            await CargarEventosAsignados();

            // Cargar meses en el ComboBox
            CargarMeses();

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await CargarEventosAsignados();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un evento");
                return;
            }

            var evento = (Evento)dataGridView1.CurrentRow.DataBoundItem;

            MessageBox.Show(
                "DETALLE DEL EVENTO\n\n" +
                "Nombre: " + evento.NombreEvento + "\n" +
                "Tipo: " + evento.TipoEvento + "\n" +
                "Fecha: " + evento.Fecha.ToShortDateString() + "\n" +
                "Hora Inicio: " + evento.Hora + "\n" +
                "Lugar: " + evento.Lugar + "\n" +
                "Estado: " + evento.Estado
            );
        }

        private async void btnfiltrar_Click(object sender, EventArgs e)
        {
            try
            {


                if (cmbMes.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un mes");
                    return;
                }

                int mesSeleccionado = cmbMes.SelectedIndex + 1;

                // 🔹 Buscar invitaciones
                var invitaciones = await colInvitaciones
                    .Find(i => i.IdInvitado == usuarioActual.Id)
                    .ToListAsync();

                var idsEventos = invitaciones
                    .Select(i => i.IdEvento)
                    .ToList();

                // 🔹 Buscar eventos y filtrar por mes
                var eventos = await colEventos
                    .Find(ev => idsEventos.Contains(ev.Id))
                    .ToListAsync();

                var eventosFiltrados = eventos
                    .Where(ev => ev.Fecha.Month == mesSeleccionado)
                    .ToList();

                dataGridView1.DataSource = eventosFiltrados;

                if (eventosFiltrados.Count == 0)
                {
                    MessageBox.Show("No hay eventos en ese mes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
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
    }
}
