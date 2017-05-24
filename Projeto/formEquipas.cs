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
        public formEquipas(Modelo_Container dbContainer) {
            InitializeComponent();
            repoEquipas = new EquipasRepository(dbContainer);
            repoPlayers = new PlayerRepository(dbContainer);
            listPlayers = repoPlayers.GetPlayersList();
            foreach(Player player in listPlayers) {
                lbSemEquipa.Items.Add(player.Name + "\t" + player.Nickname);
            }
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
            repoEquipas.novaEquipa(equipa);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            bool found = false;
            if(listPlayers.Count > 0) {
                clearListaJogadores();
                foreach(Player player in listPlayers) {
                    if(player.Name.ToUpper().Contains(textBox1.Text.ToUpper()) || player.Nickname.ToUpper().Contains(textBox1.Text.ToUpper())) {
                        lbSemEquipa.Items.Add(player.Name + "\t" + player.Nickname);
                        found = true;
                    }
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

        }

        private void btRemoverEquipa_Click(object sender, EventArgs e) {

        }
    }
}
