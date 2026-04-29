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
    public partial class Lider : MaterialForm
    {
        private Usuarios usuarioActual;

        public Lider(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void Lider_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido"  +  usuarioActual.Nombre;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
