using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    public partial class formTorneios : Form {
        public formTorneios() {
            InitializeComponent();
        }

        private void cancelar(object sender, EventArgs e) {
            tbDescricao.Text = "";
            tbNome.Text = "";
            dpData.Text = DateTime.Today.ToString("d");
        }

        private void guardar(object sender, EventArgs e) {
            //TODO
        }
    }
}
