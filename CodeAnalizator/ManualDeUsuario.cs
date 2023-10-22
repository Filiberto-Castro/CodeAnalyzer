using CodeAnalizator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAnalyzer
{
    public partial class ManualDeUsuario : Form
    {

        public ManualDeUsuario()
        {
            InitializeComponent();

            // logica para mover la ventana con el mouse

            MoverComponente moverComponente = new MoverComponente();
            moverComponente.Attach(headerUserManual);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
