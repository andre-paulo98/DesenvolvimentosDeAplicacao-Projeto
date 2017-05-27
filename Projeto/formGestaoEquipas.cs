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
    public partial class formGestaoEquipas : Form {
        private EquipasRepository eqRepo;
        Modelo_Container dbContainer;
        public formGestaoEquipas(Modelo_Container dbContainer) {
            InitializeComponent();
            this.dbContainer = dbContainer;
            eqRepo = new EquipasRepository(dbContainer);
            refreshList();
        }

        private void button1_Click(object sender, EventArgs e) {
            formEquipas formEquipa = new formEquipas(dbContainer);
            formEquipa.FormClosing += (object formSender, FormClosingEventArgs fromE) => {
                refreshList();
            };
            formEquipa.ShowDialog(this);
        }

        private void refreshList() {
            lbListaEquipas.Items.Clear();
            foreach(Team eq in eqRepo.GetTeamsList()) {
                lbListaEquipas.Items.Add(eq.Name + "\t" + eq.Player.Count + " jogadores");
            }
        }

        private void lbListaEquipas_SelectedIndexChanged(object sender, EventArgs e) {
            if(lbListaEquipas.SelectedIndex >= 0) {
                mostraJogadores(getSelectedTeam());
                lbListaJogadores.Visible = true;
            } else {
                lbListaJogadores.Visible = false;
            }
        }
        
        private void mostraJogadores(Team equipa) {
            lbListaJogadores.Items.Clear();
            foreach(Player player in equipa.Player) {
                lbListaJogadores.Items.Add(player.Nickname+ " ("+ player.Name+")");
            }
        }

        private Team getSelectedTeam() {
            return eqRepo.GetTeam(lbListaEquipas.SelectedIndex);
        }

        private void btRemover_Click(object sender, EventArgs e) {
            if(lbListaEquipas.SelectedIndex >= 0) {
                eqRepo.deleteTeam(eqRepo.GetTeam(lbListaEquipas.SelectedIndex));
                refreshList();
                disablePlayers();
            }
        }

        private void lbListaEquipas_DoubleClick(object sender, EventArgs e) {
            if(lbListaEquipas.SelectedIndex >= 0) {
                formEquipas formEquipa = new formEquipas(getSelectedTeam(), dbContainer);
                formEquipa.FormClosing += (object formSender, FormClosingEventArgs fromE) => {
                    refreshList();
                };
                formEquipa.ShowDialog(this);
                disablePlayers();
            }
        }

        private void disablePlayers() {
            lbListaJogadores.Visible = false;
            lbListaEquipas.SelectedIndex = -1;
        }
    }
}
