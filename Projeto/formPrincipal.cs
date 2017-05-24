using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto
{
    public partial class formPrincipal : Form
    {
        Modelo_Container dbContainer;
        FormCollection formsOpen = Application.OpenForms;
        public formPrincipal(Modelo_Container dbContainer)
        {
            InitializeComponent();
            this.dbContainer = dbContainer;
        }

        private void btUtilizadores_Click(object sender, EventArgs e)
        {
            if (!formsOpen.OfType<formPickUser>().Any()) {
                new formPickUser(dbContainer).Show();
            }else {
                formsOpen.OfType<formPickUser>().First().Focus();
            }
        }

        private void btBaralhos_Click(object sender, EventArgs e) {
            if (!formsOpen.OfType<formBaralhos>().Any()) {
                new formBaralhos(dbContainer).Show();
            } else {
                formsOpen.OfType<formBaralhos>().First().Focus();
            }
		}     

        private void btTorneios_Click(object sender, EventArgs e) {
            if (!formsOpen.OfType<formTorneios>().Any()) {
                new formTorneios(dbContainer,false).Show();
            } else {
                formsOpen.OfType<formTorneios>().First().Focus();
            }
        }

        private void btJogadores_Click(object sender, EventArgs e) {
            if (!formsOpen.OfType<formJogadores>().Any()) {
                new formJogadores(dbContainer).Show();
            } else {
                formsOpen.OfType<formJogadores>().First().Focus();
            }
        }

        private void btCartas_Click(object sender, EventArgs e) {
            if (!formsOpen.OfType<formCartas>().Any()) {
                new formCartas(dbContainer).Show();
            } else {
                formsOpen.OfType<formCartas>().First().Focus();
            }
        }

        private void btEquipas_Click(object sender, EventArgs e) {
            if(!formsOpen.OfType<formGestaoEquipas>().Any()) {
                new formGestaoEquipas(dbContainer).Show();
            } else {
                formsOpen.OfType<formGestaoEquipas>().First().Focus();
            }
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();

        }
    }
}
