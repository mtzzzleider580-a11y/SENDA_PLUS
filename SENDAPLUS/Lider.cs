using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SENDAPLUS
{
    public partial class Lider : MaterialForm
    {
        private readonly Usuarios usuarioActual;
        private readonly IMongoCollection<BsonDocument> _eventosCollection;

        public Lider(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            // Inicializar conexión directa a MongoDB evitando dependencias de modelos no definidos
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("SENDAPLUS");
            _eventosCollection = db.GetCollection<BsonDocument>("Evento");

            // Asociar manejadores
            this.Load += Lider_Load;
            btnCrearEvento.Click += BtnCrearEvento_Click;
            btnConsultarEvento.Click += BtnConsultarEvento_Click;
            btnActualizarEventos.Click += BtnActualizarEventos_Click;
            btnCerrarSesión.Click += BtnCerrarSesión_Click;
        }

        private async void Lider_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + usuarioActual?.Nombre;
            await CargarTodosEventosAsync();
        }

        private async Task CargarTodosEventosAsync()
        {
            try
            {
                dataGridView1.Rows.Clear();
                var docs = await _eventosCollection.Find(new BsonDocument()).ToListAsync();
                foreach (var doc in docs)
                {
                    AñadirFilaDesdeDocumento(doc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar eventos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AñadirFilaDesdeDocumento(BsonDocument doc)
        {
            // Lectura robusta de campos (ajusta nombres si tu colección usa otros)
            string id = doc.GetValue("_id", BsonNull.Value).ToString();
            string nombre = doc.Contains("nombre") ? doc["nombre"].AsString : (doc.Contains("NombreEvento") ? doc["NombreEvento"].AsString : "");
            string tipo = doc.Contains("tipo") ? doc["tipo"].AsString : "";
            string lugar = doc.Contains("lugar") ? doc["lugar"].AsString : "";
            string estado = doc.Contains("estado") ? doc["estado"].AsString : "";

            string fechaStr = "";
            string horaStr = "";
            if (doc.Contains("fechaInicio") && doc["fechaInicio"].IsValidDateTime)
            {
                DateTime inicio = doc["fechaInicio"].ToUniversalTime();
                fechaStr = inicio.ToLocalTime().ToString("yyyy-MM-dd");
                horaStr = inicio.ToLocalTime().ToString("HH:mm");
            }
            else if (doc.Contains("Fecha") && doc["Fecha"].IsValidDateTime)
            {
                DateTime f = doc["Fecha"].ToUniversalTime();
                fechaStr = f.ToLocalTime().ToString("yyyy-MM-dd");
            }

            dataGridView1.Rows.Add(id, nombre, tipo, fechaStr, horaStr, lugar, estado);
        }

        private async void BtnCrearEvento_Click(object sender, EventArgs e)
        {
            // Abrir formulario de crear evento; al regresar, recargar eventos
            using (var form = new Crear_Evento())
            {
                form.ShowDialog();
            }
            await CargarTodosEventosAsync();
        }

        private async void BtnConsultarEvento_Click(object sender, EventArgs e)
        {
            string texto = materialTextBox1.Text?.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                // Si no existe texto, desplazar (poner foco) al textbox como solicitaste
                materialTextBox1.Focus();
                materialTextBox1.SelectAll();
                MessageBox.Show("Ingrese el nombre del evento a consultar.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            await BuscarYSeleccionarEventoAsync(texto);
        }

        private async Task BuscarYSeleccionarEventoAsync(string nombreABuscar)
        {
            try
            {
                // Búsqueda insensible a mayúsculas en el campo "nombre" o "NombreEvento"
                var filterNombre = Builders<BsonDocument>.Filter.Regex("nombre", new BsonRegularExpression(nombreABuscar, "i"));
                var filterNombreAlt = Builders<BsonDocument>.Filter.Regex("NombreEvento", new BsonRegularExpression(nombreABuscar, "i"));
                var filter = Builders<BsonDocument>.Filter.Or(filterNombre, filterNombreAlt);

                var resultados = await _eventosCollection.Find(filter).ToListAsync();

                dataGridView1.Rows.Clear();
                foreach (var doc in resultados)
                {
                    AñadirFilaDesdeDocumento(doc);
                }

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron eventos con ese nombre.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // desplazar foco al textbox para facilitar corrección
                    materialTextBox1.Focus();
                    materialTextBox1.SelectAll();
                    return;
                }

                // Seleccionar la primera fila y desplazar el DataGridView para que sea visible
                if (dataGridView1.Rows.Count > 0)
                {
                    var rowIndex = 0;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;
                    // Asegurar que el índice sea válido antes de asignar FirstDisplayedScrollingRowIndex
                    if (rowIndex < dataGridView1.RowCount)
                    {
                        dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnActualizarEventos_Click(object sender, EventArgs e)
        {
            await CargarTodosEventosAsync();
        }

        private void BtnCerrarSesión_Click(object sender, EventArgs e)
        {
            // Cerrar sesión: volver al login (ajusta si tu formulario de login se llama distinto)
            var r = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                var login = new FormLogin();
                login.Show();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // opcional
        }
    }
}