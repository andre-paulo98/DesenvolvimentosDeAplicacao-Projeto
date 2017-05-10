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
    public partial class formJogadores : Form {

        private Modelo_Container dbContainer;
        private PlayerRepository playerRepo;
        private List<Player> listaPlayers;
        bool flagEditar = false;

        public formJogadores(Modelo_Container dbContainer) {
            this.dbContainer = dbContainer;
            InitializeComponent();
            playerRepo = new PlayerRepository(dbContainer);
            listaPlayers = playerRepo.GetPlayersList();
        }

        private void btNovo_Click(object sender, EventArgs e) {
            flagEditar = false;
            AtivarForm(true);
        }

        private void btGuardar_Click(object sender, EventArgs e) {
            if (flagEditar) {//MODO EDIÇAO

                flagEditar = false;
            } else {//MODO DE INSERÇAO

            }
            AtivarForm(false);
        }

        private void btEliminar_Click(object sender, EventArgs e) {
            if(flagEditar) {//MODO EDIÇAO

                flagEditar = false;
            }
            AtivarForm(false);
        }

        private void pbAvatar_Click(object sender, EventArgs e) {
            ofdAvatar.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofdAvatar.ShowDialog() != DialogResult.Cancel) {
                pbAvatar.Load(ofdAvatar.FileName);
                btLimpaImage.Visible = true;
            }
        }

        private void btLimpaImage_Click(object sender, EventArgs e) {
            pbAvatar.Image = pbAvatar.ErrorImage;
            btLimpaImage.Visible = false;
        }

        private void lbJogadores_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbJogadores.SelectedIndex >=0) {
                flagEditar = true;
                AtivarForm(true);
                //LoadJogador();
            }
        }

        private void btSearch_Click(object sender, EventArgs e) {

        }

        private void btSearchClear_Click(object sender, EventArgs e) {

        }

        private void AtivarForm(bool flag) {
            gbFormJogador.Enabled = flag;
            pBotoes.Enabled = flag;
            if (!flag) {
                LimpaForm();
            }

            if (flagEditar) {
                btGuardar.Text = "Guardar Edição";
                btEliminar.Text = "Eliminar";
            } else {
                btGuardar.Text = "Guardar";
                btEliminar.Text = "Cancelar";
            }
        }

        private void LimpaForm() {
            lbJogadores.SelectedIndex = -1;
            tbEmail.Text = "";
            tbNickName.Text = "";
            tbNome.Text = "";
            nudIdade.Value = 0;
            pbAvatar.Image = null;
        }

        private void RefreshView() {

        }

        private void pbAvatar_Paint(object sender, PaintEventArgs e) {
            
        }
    }
}
