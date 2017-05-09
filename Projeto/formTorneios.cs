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
        private bool btGuardarEstado = false;

        private TournamentRepository tourRepo;
        public formTorneios(Modelo_Container dbContainer) {
            InitializeComponent();
            this.dbContainer = dbContainer;
            tourRepo = new TournamentRepository(dbContainer);
            dpData.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            listaTorneios();
        }
        

        private void cancelar(object sender, EventArgs e) {
            tbDescricao.Text = "";
            tbNome.Text = "";
            dpData.Text = DateTime.Today.ToString("d");
            btGuardarEstado = false;
            btEliminar.Visible = false;
        }

        private void guardar(object sender, EventArgs e) {
            Tournament torneio;
            if(!btGuardarEstado) {
                torneio = new Tournament();
                torneio.Name = tbNome.Text;
                torneio.Date = dpData.Value;
                torneio.Descrition = tbDescricao.Text;
                tourRepo.newTournament(torneio);
            } else {
                torneio = tourRepo.getListaTorneios().ElementAt(lbTorneios.SelectedIndex);
                torneio.Name = tbNome.Text;
                torneio.Date = dpData.Value;
                torneio.Descrition = tbDescricao.Text;
                tourRepo.updateTournament(torneio);
            }
            listaTorneios();
        }

        private void listaTorneios() {
            lbTorneios.Items.Clear();
            foreach(Tournament torneio in tourRepo.getListaTorneios()) {
                lbTorneios.Items.Add(torneio.Id + " - " + torneio.Name + " - " + torneio.Date);
            }
        }

        private void lbTorneios_SelectedIndexChanged(object sender, EventArgs e) {
            int idT = Int32.Parse(lbTorneios.Items[lbTorneios.SelectedIndex].ToString().Split('-')[0].Trim());
            Tournament torneio = tourRepo.getTournamentID(idT);
            tbNome.Text = torneio.Name;
            dpData.Value = torneio.Date;
            tbDescricao.Text = torneio.Descrition;
            btGuardarEstado = true;
            btEliminar.Visible = true;
        }

        private void btEliminar_Click(object sender, EventArgs e) {
            Tournament torneio;
            torneio = tourRepo.getListaTorneios().ElementAt(lbTorneios.SelectedIndex);
            tourRepo.deleteTournament(torneio);
            listaTorneios();
            btCancelar.PerformClick();
        }
    }
}
