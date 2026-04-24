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
using static SENDAPLUS.ConexionMongo;
using static SENDAPLUS.Usuarios;

namespace SENDAPLUS
{
    public partial class Logins : Form
    {
        public Logins()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var conexion = new Conectar();

                var total = await conexion.Usuarios().CountDocumentsAsync(Builders<Usuarios>.Filter.Empty);

                MessageBox.Show("Conectado. Usuarios: " + total);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
