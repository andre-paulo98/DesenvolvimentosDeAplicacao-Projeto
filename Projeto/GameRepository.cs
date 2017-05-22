using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto {
    class GameRepository {
        private Modelo_Container dbConteirner;

        public GameRepository() {
            dbConteirner = new Modelo_Container();
        }

        public bool AddStandardGame(StandardGame jogo) {
            bool flag = StandardGameChecker(jogo);
            if (flag) {
                dbConteirner.Game.Add(jogo);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool AddTeamGame(TeamGame jogo) {
            bool flag = TeamGameChecker(jogo);
            if (flag) {
                dbConteirner.Game.Add(jogo);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        private bool GameChecker(Game jogo) {
            bool flag = false;
            if (jogo.Referee == null) {
                throw new Exception("Arbitro do jogo não definido!");
            } else if (jogo.DeckOne == null) {
                throw new Exception("Baralho1 do jogo não definido!");
            } else if (jogo.DeckTwo == null) {
                throw new Exception("Baralho2 do jogo não definido!");
            } 
            return flag;
        }
        private bool StandardGameChecker(Game jogo) {
            bool flag = false;
            return flag;
        }
        private bool TeamGameChecker(Game jogo) {
            bool flag = false;
            return flag;
        }
    }
}
