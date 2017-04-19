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
    public partial class formBaralhos : Form {
        public formBaralhos() {
            InitializeComponent();
        }

        private void lbBaralhos_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbBaralhos.SelectedIndex >= 0) {
                label3.Visible = false;
                lbCartas.Visible = true;
            }else {
                label3.Visible = true;
                lbCartas.Visible = false;
            }
        }

        private void btNovo_Click(object sender, EventArgs e) {
            new formBaralhosManipula().Show();
        }

        private void lbBaralhos_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lbBaralhos.SelectedIndex >= 0) {
                Deck n = new Deck();
                n.Name = "Teste";
                new formBaralhosManipula(n).Show();
            }
        }
    }
}
