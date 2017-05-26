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
    public partial class formEquipas : Form {

        private EquipasRepository repoEquipas;
        private PlayerRepository repoPlayers;
        private List<Player> listPlayers;
        private List<Player> listSearchPlayers = new List<Player>();
        private List<Player> listPlayersInTeam = new List<Player>();
        private bool novo = true;
        private Team teamEditar;
        public formEquipas(Modelo_Container dbContainer) {
            InitializeComponent();
            repoEquipas = new EquipasRepository(dbContainer);
            repoPlayers = new PlayerRepository(dbContainer);
            listPlayers = repoPlayers.GetPlayersList();
            foreach(Player player in listPlayers) {
                lbSemEquipa.Items.Add(player.Name + "\t" + player.Nickname);
            }
            textBox1.Text = "1";textBox1.Text = "";
            novo = true;
        }


        public formEquipas(Team team, Modelo_Container dbContainer) {
            InitializeComponent();
            teamEditar = team;
            repoEquipas = new EquipasRepository(dbContainer);
            repoPlayers = new PlayerRepository(dbContainer);
            listPlayers = repoPlayers.GetPlayersListNotIn(team.Player.ToList());
            foreach(Player player in listPlayers) {
                lbSemEquipa.Items.Add(player.Name + "\t" + player.Nickname);
            }
            listPlayersInTeam = team.Player.ToList();
            foreach(Player player in team.Player) {
                lbJogadoresNaEquipa.Items.Add(player.Name + "\t" + player.Nickname);
            }
            tbNomeEquipa.Text = team.Name;
            if(team.Avatar != null)
                pbAvatar.Load(team.Avatar);

            textBox1.Text = "1";
            textBox1.Text = "";
            this.Text = "Editar equipa";
            ativarBotaoGerir();
            novo = false;
        }

        private void pbAvatar_Click(object sender, EventArgs e) {
            ofdAvatar.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if(ofdAvatar.ShowDialog() != DialogResult.Cancel) {
                pbAvatar.Load(ofdAvatar.FileName);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e) {
            if(listPlayersInTeam.Count == 2) {
                string mensagem = "";
                if(novo) {
                    Team equipa = new Team();
                    equipa.Name = tbNomeEquipa.Text.Trim();
                    equipa.Avatar = pbAvatar.ImageLocation;
                    equipa.Player = listPlayersInTeam;
                    if(repoEquipas.novaEquipa(equipa))
                        mensagem = "Equipa adicionada com sucesso";
                } else {
                    teamEditar.Name = tbNomeEquipa.Text.Trim();
                    teamEditar.Avatar = pbAvatar.ImageLocation;
                    teamEditar.Player = listPlayersInTeam;
                    if(repoEquipas.saveEquipa(teamEditar))
                        mensagem = "Equipa guardada com sucesso";
                }
                if(mensagem != "") {
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            } else {
                MessageBox.Show("As equipas têm de ter obrigatoriamente 2 jogadores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            bool found = false;
            if(listSearchPlayers.Count>0) {
                listSearchPlayers.Clear();
            }
            clearListaJogadores();
            foreach(Player player in listPlayers) {
                if(player.Name.ToUpper().Contains(textBox1.Text.ToUpper()) || player.Nickname.ToUpper().Contains(textBox1.Text.ToUpper())) {
                    listSearchPlayers.Add(player);
                    lbSemEquipa.Items.Add(player.Name + "\t" + player.Nickname);
                    found = true;
                }
            }
            if(!found) {
                lbSemEquipa.Items.Add("Nada encontrado com esse filtro");
                lbSemEquipa.SelectionMode = SelectionMode.None;
            } else {
                lbSemEquipa.SelectionMode = SelectionMode.One;
            }

        }

        private void clearListaJogadores() {
            lbSemEquipa.Items.Clear();
        }

        private void btAdicionarEquipa_Click(object sender, EventArgs e) {
            if(lbSemEquipa.SelectedIndex >= 0) {
                if(listSearchPlayers.Count() < 0) {
                    listSearchPlayers = listPlayers;
                }

                listPlayersInTeam.Add(listSearchPlayers.ElementAt(lbSemEquipa.SelectedIndex));
                listPlayers.Remove(listSearchPlayers.ElementAt(lbSemEquipa.SelectedIndex));
                listSearchPlayers.RemoveAt(lbSemEquipa.SelectedIndex);
                lbSemEquipa.Items.RemoveAt(lbSemEquipa.SelectedIndex);

                updateListbox(lbJogadoresNaEquipa, listPlayersInTeam);

                ativarBotaoGerir();
            }

        }

        private void btRemoverEquipa_Click(object sender, EventArgs e) {
            if(lbJogadoresNaEquipa.SelectedIndex >= 0) {
                Player selected = new Player();
                int selectedIndex = lbJogadoresNaEquipa.SelectedIndex;
                selected = listPlayersInTeam.ElementAt(selectedIndex);
                listSearchPlayers.Add(selected);
                listPlayers.Add(selected);
                listPlayersInTeam.RemoveAt(selectedIndex);
                lbJogadoresNaEquipa.Items.RemoveAt(selectedIndex);

                updateListbox(lbSemEquipa, listPlayers);
                ativarBotaoGerir();

            }
        }

        private void updateListbox(ListBox lb, List<Player> lPlayer) {
            lb.Items.Clear();
            foreach(Player p in lPlayer) {
                lb.Items.Add(p.Name + "\t" + p.Nickname);
            }
        }
        
        private void ativarBotaoGerir() {
            if(listPlayersInTeam.Count() == 2) {
                btAdicionarEquipa.Enabled = false;
            } else {
                btAdicionarEquipa.Enabled = true;
            }
            if(listPlayersInTeam.Count() == 0) {
                btRemoverEquipa.Enabled = false;
            } else {
                btRemoverEquipa.Enabled = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
