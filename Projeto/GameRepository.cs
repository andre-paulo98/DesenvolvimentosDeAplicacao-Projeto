using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class GameRepository {
        private Modelo_Container dbConteirner;

        public GameRepository(Modelo_Container conteiner) {
            dbConteirner = conteiner;
        }

        public bool AddGame(StandardGame jogo) {
            bool flag = StandardGameChecker(jogo);
            if (flag) {
                dbConteirner.Game.Add(jogo);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool AddGame(TeamGame jogo) {
            bool flag = TeamGameChecker(jogo);
            if (flag) {
                dbConteirner.Game.Add(jogo);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool EditGame(StandardGame jogo) {
            bool flag = StandardGameChecker(jogo);
            if (flag) {
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool EditGame(TeamGame jogo) {
            bool flag = TeamGameChecker(jogo);
            if (flag) {
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public void DeleteGame(StandardGame jogo) {
            dbConteirner.Game.Remove(jogo);
            dbConteirner.SaveChanges();
        }

        public void DeleteGame(TeamGame jogo) {
            dbConteirner.Game.Remove(jogo);
            dbConteirner.SaveChanges();
        }

        public List<StandardGame> getStandardGamesList(StandardToutnament tourn) {
            return dbConteirner.Tournament.OfType<StandardToutnament>().ToList().Find(tour => tour == tourn).Game.ToList();
        }

        public List<TeamGame> getTeamGamesList(TeamTournament tourn) {
            return dbConteirner.Tournament.OfType<TeamTournament>().ToList().Find(tour => tour == tourn).Game.ToList();
        }

        public List<StandardGame> getStandardGamesOfRefereeList(StandardToutnament tourn, Referee arbitro) {
            return (from jogo in dbConteirner.Tournament.
                    OfType<StandardToutnament>().ToList().
                    Find(t => t == tourn).Game
                    where jogo.Referee.Id == arbitro.Id
                    select jogo).ToList();
        }

        public List<TeamGame> getTeamGamesOfRefereeList(TeamTournament tourn, Referee arbitro) {
            return (from jogo in dbConteirner.Tournament.
                    OfType<TeamTournament>().ToList().
                    Find(t => t == tourn).Game
                    where jogo.Referee.Id == arbitro.Id
                    select jogo).ToList();
        }

        private bool GameChecker(Game jogo) {
            bool flag = false;
            if (jogo.Referee == null) {
                ErroMensagem("Arbitro do jogo não definido!");
            } else if (jogo.DeckOne == null) {
                ErroMensagem("Baralho1 do jogo não definido!");
            } else if (jogo.DeckTwo == null) {
                ErroMensagem("Baralho2 do jogo não definido!");
            } else if (jogo.Date == null) {
                ErroMensagem("Data do jogo não definido!");
            }else {
                flag = true;
            }
            return flag;
        }

        private bool StandardGameChecker(StandardGame jogo) {
            bool flag = GameChecker(jogo);
            if (jogo.PlayerOne == null) {
                ErroMensagem("O jogador 1 não está definido!");
                flag = false;
            } else if(jogo.PlayerTwo == null) {
                ErroMensagem("O Jogador 2 não está definida!");
                flag = false;
            }else {
                flag = true;
            }
            return flag;
        }
        private bool TeamGameChecker(TeamGame jogo) {
            bool flag = GameChecker(jogo);
            if (jogo.TeamOne == null) {
                ErroMensagem("A equipa 1 não está definido!");
                flag = false;
            } else if (jogo.TeamTwo == null) {
                ErroMensagem("A equipa 2 não está definida!");
                flag = false;
            } else {
                flag = true;
            }
            return flag;
        }

        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Jogos - Dados Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
