using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SENDAPLUS
{
    public partial class Lider : Form
    {
        private Usuarios usuarioActual;

        public Lider(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }
    }
}
