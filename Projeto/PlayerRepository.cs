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

        public void DeletePlayer(Player player) {
            if (CheckDelete(player)) {
                dbConteirner.Player.Remove(player);
                dbConteirner.SaveChanges();
            }else {
                MessageBox.Show("Este Jogador está associoado a uma equipa!\n" +
                    "Apenas poderá se eliminado caso não existam associações a nenhuma equipa!", "Jogador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public List<Player> GetPlayersListNotIn(List<Player> players) {
            return (from player in dbConteirner.Player.ToList()
                    where !(players.Contains(player))
                    select player).ToList();
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
            } else if (!jogador.Email.Contains('@') || !jogador.Email.Contains('.')) {
                ErroMensagem("O valor campo \"Email\" não é valido!");
            } else if (jogador.Nickname.Length == 0) {
                ErroMensagem("O campo \"Nikcname\"não está preenchido!");
            } else if (jogador.Age <= 0) {
                ErroMensagem("O valor do campo \"Idade\" não é valido!\n" +
                    " A \"Idade\" deve ser superior a \"0\".");
            } else {
                flag = true;
            }
            return flag;
        }

        private bool CheckDelete(Player player) {
            bool flag = true;
            List<Team> listaEquipas = (from team in dbConteirner.Team
                                       where team.Player.Any(pl => pl.Id == player.Id)
                                       select team).ToList();
            if(listaEquipas.Count > 0) {
                flag = false;
            }

            return flag;
        }

        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Jogador - Dados Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
