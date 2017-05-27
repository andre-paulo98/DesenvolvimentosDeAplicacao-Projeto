using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class TournamentRepository {
        private Modelo_Container dbContainer;

        public TournamentRepository(Modelo_Container dbContainer) {
            this.dbContainer = dbContainer;
        }

        public bool AddTournament(StandardToutnament torneio) {
            bool flag = checkTournament(torneio);
            if(flag) {
                dbContainer.Tournament.Add(torneio);
                dbContainer.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool AddTournament(TeamTournament torneio) {
            bool flag = checkTournament(torneio);
            if (flag) {
                dbContainer.Tournament.Add(torneio);
                dbContainer.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool EditTournament(StandardToutnament torneio) {
            bool flag = checkTournament(torneio);
            if (flag) {
                dbContainer.SaveChanges();
            }
            return flag;
        }

        public bool EditTournament(TeamTournament torneio) {
            bool flag = checkTournament(torneio);
            if (flag) {
                dbContainer.SaveChanges();
            }
            return flag;
        }

        public void DeleteTournament(Tournament torneio) {
            dbContainer.Tournament.Remove(torneio);
            dbContainer.SaveChanges();
        }

        public List<StandardToutnament> getStandardTournamentList() {
            return dbContainer.Tournament.OfType<StandardToutnament>().ToList();
        }

        public List<TeamTournament> getTeamTournamentList() {
            return dbContainer.Tournament.OfType<TeamTournament>().ToList();
        }

        public List<StandardToutnament> getStandardTournamentOfRefereeList(Referee arbitro) {
            return (from tourn in dbContainer.Tournament.OfType<StandardToutnament>()
                    where tourn.Game.Any(jogo => jogo.Referee == arbitro)
                    select tourn).ToList();
        }

        public List<TeamTournament> getTeamTournamentOfRefereeList(Referee arbitro) {
            return (from tourn in dbContainer.Tournament.OfType<TeamTournament>()
                    where tourn.Game.Any(jogo => jogo.Referee == arbitro)
                    select tourn).ToList();
        }

        private bool checkTournament(Tournament torneio) {
            bool check = false;
            if(torneio.Name.Length == 0) {
                ErroMensagem("Não foi preenchido o Nome");
            } else if (torneio.Date.ToString().Length == 0) {
                ErroMensagem("Não foi preenchida a Data");
            } else {
                check = true;
            }
            return check;
        }

        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Torneios - Dados Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

    }
}
