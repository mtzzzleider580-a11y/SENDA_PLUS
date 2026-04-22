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
        private List<Evento> listaEventos = new List<Evento>();

        public FormInvitado(Usuarios usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            label1.Text = "Bienvenido, " + usuarioActual.Nombre; // Personalizamos el saludo
        }


        private  void FormInvitado_Load(object sender, EventArgs e)
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

            cmbMes.SelectedIndex = 0;
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private  void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiamos antes de cargar
                dataGridView1.DataSource = null;

                // 1. Buscamos invitaciones e IDs
                var idsEventos = conexion.Invitacion()
                    .Find(x => x.IdInvitado == usuarioActual.Id)
                    .Project(x => x.IdEvento)
                    .ToList();

                // 2. IMPORTANTE: Guardamos en 'listaEventos' (la variable global)
                listaEventos = conexion.Eventos()
                    .Find(x => idsEventos.Contains(x.Id))
                    .ToList();

                // 3. Asignamos a la tabla
                dataGridView1.DataSource = listaEventos;

                if (listaEventos.Count == 0) MessageBox.Show("No tienes invitaciones.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }
        }

        // no se usa 
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            // 1. Validar que haya una fila seleccionada
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un evento de la lista.");
                return;
            }

            // 2. Obtener el ID de la celda "ID" (Asegúrate de que la columna se llame "ID" en tu diseño)
            var idBusqueda = dataGridView1.CurrentRow.Cells["ID"].Value?.ToString();

            // 3. Buscar el evento en nuestra lista local (más rápido que volver a la base de datos)
            var evento = listaEventos.FirstOrDefault(x => x.Id.ToString() == idBusqueda);

            if (evento != null)
            {
                // 4. Construir el mensaje con los detalles
                string detalles = $@"Detalles del Evento:
--------------------------------------
Nombre: {evento.NombreEvento}
Tipo:   {evento.TipoEvento}
Fecha:  {evento.Fecha.ToLocalTime():dd/MM/yyyy}
Hora:   {evento.Hora}
Lugar:  {evento.Lugar}
Estado: {evento.Estado}
--------------------------------------";

                MessageBox.Show(detalles, "Información del Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo cargar la información del evento.");
            }
        }

        private  void btnfiltrar_Click(object sender, EventArgs e)
        { // Si la lista global está vacía, no hay nada que filtrar
            if (listaEventos == null || listaEventos.Count == 0)
            {
                MessageBox.Show("Primero debe Consultar Eventos.");
                return;
            }

            int mesBuscado = cmbMes.SelectedIndex + 1;

            // Filtramos sobre la lista que ya cargamos en btnConsultar
            var filtrados = listaEventos
                .Where(x => x.Fecha.Month == mesBuscado)
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtrados;

            if (filtrados.Count == 0)
                MessageBox.Show($"No hay eventos para el mes {cmbMes.Text}");

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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿desea volver al inicio?", "VOLVER", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                FormLogin log = new FormLogin();
                log.Show();
                this.Hide();
            }

        }
    }
}
