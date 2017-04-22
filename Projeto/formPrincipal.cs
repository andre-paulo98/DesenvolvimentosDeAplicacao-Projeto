using System;
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
            formPickUser pickUser = new formPickUser();
            pickUser.Show();
        }

        private void btBaralhos_Click(object sender, EventArgs e) {
            formBaralhos gestaoBaralhos = new formBaralhos();
            gestaoBaralhos.Show();
		}
		
        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
			
        }

        private void btTorneios_Click(object sender, EventArgs e) {
            formTorneios gestaoTorneios = new formTorneios();
            gestaoTorneios.Show();
        }

        private void btJogadores_Click(object sender, EventArgs e) {
            formJogadores gestaoJogadores = new formJogadores();
            gestaoJogadores.Show();
        }

        private void btCartas_Click(object sender, EventArgs e) {
            formCartas gestaoCartas = new formCartas();
            gestaoCartas.Show();
        }
    }
}
