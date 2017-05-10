using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class PlayerRepository {

        private Modelo_Container dbConteirner;

        public PlayerRepository(Modelo_Container dbConteirner) {
            this.dbConteirner = dbConteirner;
        }

        public bool AddPlayer(Player player) {
            bool flag = PlayerChecker(player);
            if (flag) {
                dbConteirner.Player.Add(player);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool EditPlayer(Player player) {
            bool flag = PlayerChecker(player);
            if (flag && player.Id != 0) {
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool DeletePlayer(Player player) {
            bool flag = PlayerChecker(player);
            if (flag) {
                dbConteirner.Player.Remove(player);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public List<Player> GetPlayersList() {
            return dbConteirner.Player.ToList();
        }

        public List<Player> SearchPlayer(String name) {
            return (from Player in dbConteirner.Player.ToList()
                    where Player.Name.ToUpper().Contains(name.ToUpper())
                    select Player).ToList();
        }

        public bool PlayerChecker(Player jogador) {
            bool flag = false;
            if (jogador.Name.Length == 0) {
                ErroMensagem("O campo \"Nome\" não está preenchido!");
            } else if (jogador.Email.Length == 0) {
                ErroMensagem("O campo \"Email\" não está preenchido!");
            } else if (jogador.Nickname.Length == 0) {
                ErroMensagem("O campo \"Nikcname\"não está preenchido!");
            } else if (jogador.Age <= 0) {
                ErroMensagem("O valor do campo \"Custo\" não é valido!\n" +
                    " O \"Custo\" deve ser superior a \"0\".");
            } else if (jogador.Avatar.Length <= 0) {
                ErroMensagem("O valor do campo \"Lealdade\" não é valido!\n" +
                    "A \"Lealdade\" deve ser superior a \"0\".");
            } else {
                flag = true;
            }
            return flag;
        }
        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Jogador - Dados Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
