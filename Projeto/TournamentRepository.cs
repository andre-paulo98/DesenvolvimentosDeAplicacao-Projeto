using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class TournamentRepository {
        private Modelo_Container dbContainer;
        private List<Tournament> listaTorneios;

        public TournamentRepository(Modelo_Container dbContainer) {
            this.dbContainer = dbContainer;
            listaTorneios = new List<Tournament>();
        }

        public void newTournament(Tournament torneio) {
            if(checkTorneio(torneio)) {
                listaTorneios.Add(torneio);
                dbContainer.Tournament.Add(torneio);
                dbContainer.SaveChanges();
            }
        }

        private bool checkTorneio(Tournament torneio) {
            bool check = false;
            if(torneio.Name.Length == 0) {
                mostraErro("Não foi preenchido o Nome");
            } else if (torneio.Date.ToString().Length == 0) {
                mostraErro("Não foi preenchida a Data");
            } else {
                check = true;
            }

            return check;
        }

        private void mostraErro(string erro) {
            MessageBox.Show(erro, "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

    }
}
