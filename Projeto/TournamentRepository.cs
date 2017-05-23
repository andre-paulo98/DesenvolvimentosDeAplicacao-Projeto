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
            bool flag = checkStandardTournament(torneio);
            if(flag) {
                dbContainer.Tournament.Add(torneio);
                dbContainer.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool AddTournament(TeamTournament torneio) {
            bool flag = checkTeamTournament(torneio);
            if (flag) {
                dbContainer.Tournament.Add(torneio);
                dbContainer.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool EditTournament(StandardToutnament torneio) {
            bool flag = checkStandardTournament(torneio);
            if (flag) {
                dbContainer.SaveChanges();
            }
            return flag;
        }

        public bool EditTournament(TeamTournament torneio) {
            bool flag = checkTeamTournament(torneio);
            if (flag) {
                dbContainer.SaveChanges();
            }
            return flag;
        }

        public bool DeleteTournament(StandardToutnament torneio) {
            bool flag = checkStandardTournament(torneio);
            if (flag) {
                dbContainer.SaveChanges();
            }
            return flag;
        }

        public bool DeleteTournament(TeamTournament torneio) {
            bool flag = checkTeamTournament(torneio);
            if (flag) {
                dbContainer.SaveChanges();
            }
            return flag;
        }

        public List<Tournament> getToutnamentList() {
            return dbContainer.Tournament.ToList();
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

        private bool checkTeamTournament(TeamTournament torneio) {
            bool check = checkTournament(torneio);
            if (check) {
                if (torneio.Game.Count <= 0) {
                    throw new Exception("A Lista de Jogos não está preenchida!");
                } else if (torneio.Team.Count <= 0) {
                    throw new Exception("A Lista de Equipas não está preenchida!");
                }
            }
            return check;
        }

        private bool checkStandardTournament(StandardToutnament torneio) {
            bool check = checkTournament(torneio);
            if (check) {
                if (torneio.Game.Count <= 0) {
                    throw new Exception("A Lista de Jogos não está preenchida!");
                } else if (torneio.Player.Count <= 0) {
                    throw new Exception("A Lista de Jogadores não está preenchida!");
                }
            }
            return check;
        }

        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Torneios - Dados Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

    }
}
