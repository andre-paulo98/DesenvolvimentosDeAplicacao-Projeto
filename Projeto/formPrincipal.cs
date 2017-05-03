using System;
using System.Windows.Forms;

namespace Projeto
{
    public partial class formPrincipal : Form
    {
        Modelo_Container dbContainer;
        public formPrincipal(Modelo_Container dbContainer)
        {
            InitializeComponent();
            this.dbContainer = dbContainer;
        }

        private void btUtilizadores_Click(object sender, EventArgs e)
        {
            formPickUser pickUser = new formPickUser(dbContainer);
            pickUser.Show();
        }

        private void btBaralhos_Click(object sender, EventArgs e) {
            formBaralhos gestaoBaralhos = new formBaralhos(dbContainer);
            gestaoBaralhos.Show();
		}
		
        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
			
        }

        private void btTorneios_Click(object sender, EventArgs e) {
            formTorneios gestaoTorneios = new formTorneios(dbContainer);
            gestaoTorneios.Show();
        }

        private void btJogadores_Click(object sender, EventArgs e) {
            formJogadores gestaoJogadores = new formJogadores(dbContainer);
            gestaoJogadores.Show();
        }

        private void btCartas_Click(object sender, EventArgs e) {
            formCartas gestaoCartas = new formCartas(dbContainer);
            gestaoCartas.Show();
        }
    }
}
