using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaDeRPGACoroaDeGhanor
{
    public partial class CemiterioForm : Form
    {
        public CemiterioForm()
        {
            InitializeComponent();
        }

        private void btVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
