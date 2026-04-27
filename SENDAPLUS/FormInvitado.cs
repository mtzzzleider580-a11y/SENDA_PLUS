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

        public FormInvitado(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }
    }
}
