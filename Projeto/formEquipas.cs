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
        public formEquipas(Modelo_Container dbContainer) {
            InitializeComponent();
            repoEquipas = new EquipasRepository(dbContainer);
            repoPlayers = new PlayerRepository(dbContainer);
            listPlayers = repoPlayers.GetPlayersList();
            foreach(Player player in listPlayers) {
                lbSemEquipa.Items.Add(player.Name + "\t" + player.Nickname);
            }
            textBox1.Text = "1";textBox1.Text = "";
        }

        public formEquipas(Team team, Modelo_Container dbContainer) {
            InitializeComponent();
            repoEquipas = new EquipasRepository(dbContainer);
            repoPlayers = new PlayerRepository(dbContainer);
            listPlayers = repoPlayers.GetPlayersListNotIn((List<Player>)team.Player);
            foreach(Player player in listPlayers) {
                lbSemEquipa.Items.Add(player.Name + "\t" + player.Nickname);
            }
            textBox1.Text = "1";
            textBox1.Text = "";
            this.Text = "Editar equipa";
        }

        private void pbAvatar_Click(object sender, EventArgs e) {
            ofdAvatar.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if(ofdAvatar.ShowDialog() != DialogResult.Cancel) {
                pbAvatar.Load(ofdAvatar.FileName);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e) {
            Team equipa = new Team();
            equipa.Name = tbNomeEquipa.Text.Trim();
            equipa.Avatar = pbAvatar.ImageLocation;
            equipa.Player = listPlayersInTeam;
            repoEquipas.novaEquipa(equipa);
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
    }
}
