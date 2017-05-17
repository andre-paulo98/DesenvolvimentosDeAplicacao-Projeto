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
        bool flagPesquisa = false;

        public formJogadores(Modelo_Container dbContainer) {
            this.dbContainer = dbContainer;
            InitializeComponent();
            playerRepo = new PlayerRepository(dbContainer);
            RefreshList();
        }

        private void btNovo_Click(object sender, EventArgs e) {
            flagEditar = false;
            AtivarForm(true);
            LimpaForm();
        }

        private void btGuardar_Click(object sender, EventArgs e) {
            Player player;
            if (flagEditar) {
                player = listaPlayers.ElementAt(lbJogadores.SelectedIndex);
            } else {
                player = new Player();
            }

            player.Name = tbNome.Text;
            player.Nickname = tbNickName.Text;
            player.Email = tbEmail.Text;
            player.Age = (int)nudIdade.Value;
            player.Avatar = pbAvatar.ImageLocation;

            if (flagEditar) {//MODO EDIÇAO
                if (playerRepo.EditPlayer(player)) {
                    flagEditar = false;
                    RefreshList();
                }
            } else {//MODO DE INSERÇAO
                if (playerRepo.AddPlayer(player)) {
                    RefreshList();
                }
            }
            btNovo.Focus();
        }

        private void btEliminar_Click(object sender, EventArgs e) {
            if(flagEditar) {//MODO EDIÇAO
                playerRepo.DeletePlayer(listaPlayers.ElementAt(lbJogadores.SelectedIndex));
                flagEditar = false;
            }
            RefreshList();
            btNovo.Focus();
        }

        private void pbAvatar_Click(object sender, EventArgs e) {
            ofdAvatar.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofdAvatar.ShowDialog() != DialogResult.Cancel) {
                pbAvatar.Load(ofdAvatar.FileName);
                btLimpaImage.Visible = true;
            }
        }

        private void btLimpaImage_Click(object sender, EventArgs e) {
            pbAvatar.Image = null;
            pbAvatar.ImageLocation = "";
            btLimpaImage.Visible = false;
        }

        private void lbJogadores_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbJogadores.SelectedIndex >=0) {
                flagEditar = true;
                AtivarForm(true);
                LoadPlayer(listaPlayers.ElementAt(lbJogadores.SelectedIndex));
            }
        }

        private void tbSearch_GotFocus(object sender, EventArgs e) {
            if (tbSearch.Text == "Nome do Jogador ...") {
                tbSearch.Text = "";
                tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void tbSearch_LostFocus(object sender, EventArgs e) {
            if (tbSearch.Text == "") {
                tbSearch.Text = "Nome do Jogador ...";
                tbSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void btSearch_Click(object sender, EventArgs e) {
            flagPesquisa = true;
            RefreshList();
        }

        private void btSearchClear_Click(object sender, EventArgs e) {
            flagPesquisa = false;
            tbSearch.Text = "Nome do Jogador ...";
            tbSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            RefreshList();
        }

        private void AtivarForm(bool flag) {
            gbFormJogador.Enabled = flag;
            pBotoes.Enabled = flag;
            if (flagEditar) {
                btEliminar.Text = "Eliminar";
            } else {
                btEliminar.Text = "Cancelar";
            }
        }

        private void LimpaForm() {
            tbEmail.Text = "";
            tbNickName.Text = "";
            tbNome.Text = "";
            nudIdade.Value = 0;
            pbAvatar.Image = null;
            pbAvatar.ImageLocation = "";
            btLimpaImage.Visible = false;
        }

        private void RefreshList() {
            if (flagPesquisa) {
                listaPlayers = playerRepo.SearchPlayer(tbSearch.Text);
                if (listaPlayers.Count <=0) {
                    tbSearch.Text = "Nome do Jogador ...";
                    tbSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                    listaPlayers = playerRepo.GetPlayersList();
                    flagPesquisa = false;
                }
            } else {
                listaPlayers = playerRepo.GetPlayersList();
            }
            AtivarForm(false);
            LimpaForm();
            lbJogadores.Items.Clear();
            foreach (Player player in listaPlayers) {
                lbJogadores.Items.Add(player.Name + "\t" + player.Nickname+ "\t" + player.Age);
            }
        }

        public void LoadPlayer(Player player) {
            LimpaForm();
            tbNome.Text = player.Name;
            tbEmail.Text = player.Email;
            tbNickName.Text = player.Nickname;
            nudIdade.Value = player.Age;
            if (player.Avatar != "") {
                btLimpaImage.Visible = true;
                pbAvatar.Load(player.Avatar);
            }else {
                btLimpaImage.Visible = false;
                pbAvatar.Image = null;
                pbAvatar.ImageLocation = "";
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btSearch.PerformClick();
            }
           
        }
    }
}
