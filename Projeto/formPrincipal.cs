using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btUtilizadores_Click(object sender, EventArgs e)
        {
            formGestaoUtilizadores gestaousers = new formGestaoUtilizadores();
            gestaousers.Show();
        }
    }
}
