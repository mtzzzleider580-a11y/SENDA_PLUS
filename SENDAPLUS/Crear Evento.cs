using MaterialSkin;
using MaterialSkin.Controls;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace SENDAPLUS
{
    public partial class Crear_Evento : MaterialForm
    {
        private Usuarios usuarioActual;
        ConexionMongo.Conectar conexion = new ConexionMongo.Conectar();

        public Crear_Evento(Usuarios usuario)
        {
            InitializeComponent(); // <--- SIN ESTA LÍNEA LA VENTANA SALE VACÍA
            this.usuarioActual = usuario;
            CargarEventos(); // Para que la tabla se llene apenas abra

            // MaterialSkin aqui se configura el tema y los colores de el formulario
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green600,
                Primary.Green700,
                Primary.Green200,
                Accent.LightGreen200,
                TextShade.BLACK
            );
        }
       





        private void btActualizarEvento_Click(object sender, EventArgs e)
        {
            // 1. PRIMERO: Verificar si seleccionó algo de la tabla
            if (string.IsNullOrEmpty(idSeleccionado))
            {
                MessageBox.Show("Por favor, selecciona un evento de la tabla para ver sus datos y poder actualizar.");
                return; // Se detiene aquí si no hay selección
            }

            // 2. SEGUNDO: Verificar si dejó campos vacíos después de editar
            if (string.IsNullOrWhiteSpace(txtnombrevento.Text) || string.IsNullOrWhiteSpace(txtLugar.Text))
            {
                MessageBox.Show("No puedes dejar datos vacíos .");
                return;
            }

            // 3. Si todo está bien, procede a guardar los cambios en MongoDB
            try
            {
                var eventoEditado = new Evento
                {
                    Id = idSeleccionado,
                    NombreEvento = txtnombrevento.Text,
                    TipoEvento = combotipoe.Text,
                    Fecha = datefechaini.Value.Date,
                    Hora = datefechafin.Value.ToString("HH:mm"),
                    Lugar = txtLugar.Text,
                    Estado = comboestado.Text
                };

                var filtro = Builders<Evento>.Filter.Eq(x => x.Id, idSeleccionado);
                conexion.Eventos().ReplaceOne(filtro, eventoEditado);

                MessageBox.Show("Evento actualizado correctamente");
                CargarEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

     
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show(); // Muestra la ventana anterior
            this.Hide();
        }


        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // creamos un evento 
        private void btnGuardarevento_Click(object sender, EventArgs e)
        {


            // 1. EL BLOQUEO: Si el nombre o el lugar están vacíos, no sigue.
            if (string.IsNullOrWhiteSpace(txtnombrevento.Text) || string.IsNullOrWhiteSpace(txtLugar.Text))
            {
                MessageBox.Show("Faltan campos por llenar .");
                return; // Este 'return' es el que evita que se cree el evento
            }

            // 2. Si pasó la validación, entonces sí creamos el objeto
            var nuevoEvento = new Evento
            {
                NombreEvento = txtnombrevento.Text,
                TipoEvento = combotipoe.Text,
                Fecha = datefechaini.Value.Date,
                Hora = datefechafin.Value.ToString("HH:mm"),
                Lugar = txtLugar.Text,
                Estado = comboestado.Text
            };

            // 3. Guardar en MongoDB
            try
            {
                conexion.Eventos().InsertOne(nuevoEvento);
                MessageBox.Show("Evento registrado correctamente");

                CargarEventos(); // Refrescar la tabla

                // 4. Limpiar los cuadros para un nuevo registro
                txtnombrevento.Clear();
                txtLugar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }



        }

        private void txtLugar_TextChanged(object sender, EventArgs e)
        {

        }

        string idSeleccionado = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        // aca mostramos eventos 
        private void txtcargarevento_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtenemos todos los eventos de tu colección
                var listaEventos = conexion.Eventos().Find(_ => true).ToList();

                // 2. Los mostramos en el DataGridView
                // Asegúrate de que el nombre del control sea el correcto (ej. dgvEventos)
                dataEVENTOSv.DataSource = listaEventos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }



        private void txtnombrevento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconsultarevento_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtconsultarevento.Text.ToLower();

            // Buscamos en MongoDB los eventos que contengan lo que el usuario escribe
            // Usamos 'i' para que no importe si es mayúscula o minúscula
            var eventosFiltrados = conexion.Eventos()
                .Find(x => x.NombreEvento.ToLower().Contains(filtro))
                .ToList();

            // Actualizamos la tabla con los resultados
            dataEVENTOSv.DataSource = eventosFiltrados;
        }





        private void dataEVENTOSv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Obtenemos la fila seleccionada
                    DataGridViewRow fila = dataEVENTOSv.Rows[e.RowIndex];

                    // Asignamos por posición de columna (0, 1, 2...)
                    idSeleccionado = fila.Cells[0].Value?.ToString();
                    txtnombrevento.Text = fila.Cells[1].Value?.ToString();
                    combotipoe.Text = fila.Cells[2].Value?.ToString();
                    // La fecha suele ser la columna 3
                    if (fila.Cells[3].Value != null)
                        datefechaini.Value = Convert.ToDateTime(fila.Cells[3].Value);

                    txtLugar.Text = fila.Cells[5].Value?.ToString();
                    comboestado.Text = fila.Cells[6].Value?.ToString();
                }
                catch
                {
                    // Si una columna no existe, el catch vacío evita que el programa se cierre
                }
            }
        }


        // por aca creo el metodo cargar evento para la consulta 

        private void CargarEventos()
        {
            try
            {
                // 1. Limpiamos la tabla antes de cargar
                dataEVENTOSv.DataSource = null;
                dataEVENTOSv.Columns.Clear();

                // 2. Traemos los datos de Mongo
                var lista = conexion.Eventos().Find(_ => true).ToList();

                // 3. Asignamos la lista
                dataEVENTOSv.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

}
