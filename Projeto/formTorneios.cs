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

        private Modelo_Container dbContainer;

        private TournamentRepository tourRepo;

        private bool flagEditarTorneio = false;
        private bool flagEditarJogo = false;

        private List<Tournament> listaTorneios;
        public formTorneios(Modelo_Container dbContainer) {
            InitializeComponent();
            this.dbContainer = dbContainer;
            tourRepo = new TournamentRepository(dbContainer);
            RefreshList();
            dpData.CustomFormat = "yyyy/MM/dd HH:mm:ss";
        }

        private void btNovoTorn_Click(object sender, EventArgs e) {
            if (!flagEditarTorneio) {//MODO INSERÇAO
                AtivarFormTorneio(true);
                AtivarFormJogo(true);
            }else {//MODO EDIÇAO

            }
        }

        private void btRemoverTorn_Click(object sender, EventArgs e) {
            if (!flagEditarTorneio) {//MODO INSERÇAO

            } else {//MODO EDIÇAO

            }
        }

        private void lbTorneios_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbTorneios.SelectedIndex >= 0) {
                tbNome.Text = listaTorneios.ElementAt(lbTorneios.SelectedIndex).Name;
            }
        }

        private void btNovoJog_Click(object sender, EventArgs e) {
            if (!flagEditarJogo) {//MODO INSERÇAO
                
            } else {//MODO EDIÇAO

            }
        }

        private void btRemoverJog_Click(object sender, EventArgs e) {
            if (!flagEditarJogo) {//MODO INSERÇAO

            } else {//MODO EDIÇAO

            }
        }

        private void lbJogos_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void AtivarFormTorneio(bool flag) {
            gbTorneio.Enabled = flag;
            if (flagEditarJogo) {
                btNovoTorn.Text = "Guardar";
                btRemoverTorn.Text = "Remover";
            } else {
                btNovoTorn.Text = "Novo";
                btRemoverTorn.Text = "Cancelar";
            }
        }

        private void AtivarFormJogo(bool flag) {
            gbJogos.Enabled = flag;
            if (flagEditarJogo) {
                btNovoJog.Text = "Guardar";
                btRemoverJog.Text = "Remover";
            }else {
                btNovoJog.Text = "Novo";
                btRemoverJog.Text = "Cancelar";
            }
        }

        private void LimpaForm() {
            
        }

        private void RefreshList() {
            LimpaForm();
            listaTorneios = tourRepo.getToutnamentList();
            lbTorneios.Items.Clear();
            foreach(Tournament torn in listaTorneios) {
                lbTorneios.Items.Add(torn.Name + "\t" + torn.Date);
            }
        }

        public void LoadPlayer(Player player) {
            LimpaForm();
        }

        private void gbTorneio_Enter(object sender, EventArgs e) {

        }
    }
}
