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

        public bool DeleteGame(StandardGame jogo) {
            bool flag = StandardGameChecker(jogo);
            if (flag) {
                dbConteirner.Game.Remove(jogo);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool DeleteGame(TeamGame jogo) {
            bool flag = TeamGameChecker(jogo);
            if (flag) {
                dbConteirner.Game.Remove(jogo);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public List<StandardGame> getStandardGamesList(StandardToutnament tourn) {
            return dbConteirner.Tournament.OfType<StandardToutnament>().ToList().Find(tour => tour == tourn).Game.ToList();
        }

        public List<TeamGame> getTeamGamesList(TeamTournament tourn) {
            return dbConteirner.Tournament.OfType<TeamTournament>().ToList().Find(tour => tour == tourn).Game.ToList();
        }

        private bool GameChecker(Game jogo) {
            bool flag = false;
            if (jogo.Referee == null) {
                ErroMensagem("Arbitro do jogo não definido!");
            } else if (jogo.DeckOne == null) {
                ErroMensagem("Baralho1 do jogo não definido!");
            } else if (jogo.DeckTwo == null) {
                ErroMensagem("Baralho2 do jogo não definido!");
            } else if (!NumeroGameCheck(jogo.Number)) {
                ErroMensagem("Numero já existente!\n Escolha um novo numero.");
            } else if (jogo.Date == null) {
                ErroMensagem("Data do jogo não definido!");
            }else {
                flag = true;
            }
            return flag;
        }

        private bool StandardGameChecker(StandardGame jogo) {
            bool flag = false;
            if (!GameChecker(jogo)) {

            }else if (jogo.PlayerOne == null) {
                ErroMensagem("O jogador 1 não está definido!");
            }else if(jogo.PlayerTwo == null) {
                ErroMensagem("O Jogador 2 não está definida!");
            }else {
                flag = true;
            }
            return flag;
        }
        private bool TeamGameChecker(TeamGame jogo) {
            bool flag = false;
            if (!GameChecker(jogo)) {

            } else if (jogo.TeamOne == null) {
                ErroMensagem("A equipa 1 não está definido!");
            } else if (jogo.TeamTwo == null) {
                ErroMensagem("A equipa 2 não está definida!");
            } else {
                flag = true;
            }
            return flag;
        }

        private bool NumeroGameCheck(int numero) {
            bool flag = false;
            if (dbConteirner.Game.ToList().Find(game => game.Id == numero) == null) {
                flag = true;
            }
            return flag;
        }

        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Jogos - Dados Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
