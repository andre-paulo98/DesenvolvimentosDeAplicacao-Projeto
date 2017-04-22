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
    public partial class formAdicionarArbrito : Form
    {
        public formUserReferee formUserRefere; // *1

        public formAdicionarArbrito(formUserReferee form)
        {
            InitializeComponent();
            formUserRefere = form; // *1 Instância anterior aqui
        }

        private void formAdicionarArbrito_FormClosed(object sender, FormClosedEventArgs e)
        {
            formUserRefere.Show();
        }
    }
}
