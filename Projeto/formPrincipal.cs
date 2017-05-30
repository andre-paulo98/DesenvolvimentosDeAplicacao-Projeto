using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto
{
    public partial class formPrincipal : Form
    {
        Modelo_Container dbContainer;
        FormCollection formsOpen = Application.OpenForms;
        formLogin formlogin; 
        bool loggingout = false;
        public formPrincipal(Modelo_Container dbContainer, formLogin formlogin)
        {
            InitializeComponent();
            this.dbContainer = dbContainer;
            this.formlogin = formlogin;
        }

        private void btUtilizadores_Click(object sender, EventArgs e)
        {
            if (!formsOpen.OfType<formPickUser>().Any()) {
                new formPickUser(dbContainer).Show(this);
            }else {
                formsOpen.OfType<formPickUser>().First().Focus();
            }
        }

        private void btBaralhos_Click(object sender, EventArgs e) {
            if (!formsOpen.OfType<formBaralhos>().Any()) {
                new formBaralhos(dbContainer).Show(this);
            } else {
                formsOpen.OfType<formBaralhos>().First().Focus();
            }
		}     

        private void btTorneios_Click(object sender, EventArgs e) {
            if (!formsOpen.OfType<formTorneios>().Any()) {
                new formTorneios(dbContainer).Show(this);
            } else {
                formsOpen.OfType<formTorneios>().First().Focus();
            }
        }

        private void btJogadores_Click(object sender, EventArgs e) {
            if (!formsOpen.OfType<formJogadores>().Any()) {
                new formJogadores(dbContainer).Show(this);
            } else {
                formsOpen.OfType<formJogadores>().First().Focus();
            }
        }

        private void btCartas_Click(object sender, EventArgs e) {
            if (!formsOpen.OfType<formCartas>().Any()) {
                new formCartas(dbContainer).Show(this);
            } else {
                formsOpen.OfType<formCartas>().First().Focus();
            }
        }

        private void btEquipas_Click(object sender, EventArgs e) {
            if(!formsOpen.OfType<formGestaoEquipas>().Any()) {
                new formGestaoEquipas(dbContainer).Show(this);
            } else {
                formsOpen.OfType<formGestaoEquipas>().First().Focus();
            }
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            if(!loggingout)
                Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            loggingout = true;
            formlogin.ativaCampos();
            formlogin.Show();
            this.Close();
            
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e) {
            if(!formsOpen.OfType<formLog>().Any()) {
                new formLog().Show(this);
            } else {
                formsOpen.OfType<formLog>().First().Focus();
            }
        }
    }
}
