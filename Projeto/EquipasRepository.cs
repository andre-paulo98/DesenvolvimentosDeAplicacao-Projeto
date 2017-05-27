using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class EquipasRepository {
        private Modelo_Container dbContainer;

        public EquipasRepository(Modelo_Container dbContainer) {
            this.dbContainer = dbContainer;
        }

        public bool novaEquipa(Team equipa) {
            if(checkEquipa(equipa)) {
                dbContainer.Team.Add(equipa);
                dbContainer.SaveChanges();
                return true;
            } else
                return false;
        }
        public bool saveEquipa(Team equipa) {
            if(checkEquipa(equipa)) {
                dbContainer.SaveChanges();
                return true;
            } else
                return false;
        }

        public List<Team> GetTeamsList() {
            return dbContainer.Team.ToList();
        }

        public Team GetTeam(int pos) {
            Team team = dbContainer.Team.ToList().ElementAt(pos);
            return team;
        }

        public bool checkEquipa(Team equipa) {
            bool flag = false;
            if(equipa.Name.Length > 0) {
                flag = true;
            } else {
                ErroMensagem("Campo Nome é obrigatório");
            }
            return flag;
        }
        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Equipas - Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void deleteTeam(Team equipa) {
            if (checkDelete(equipa)) {
                dbContainer.Team.Remove(equipa);
                dbContainer.SaveChanges();
            } else {
                MessageBox.Show("Esta Equipa está associoado a um jogo!\n" +
                    "Apenas poderá se eliminado caso não exista associações a jogos!", "Equipas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkDelete(Team team) {
            bool flag = true;
            List<TeamGame> listaGames = (from game in dbContainer.Game.OfType<TeamGame>()
                                         where game.TeamOne.Id == team.Id ||
                                         game.TeamTwo.Id == team.Id
                                         select game).ToList();
            if (listaGames.Count > 0) {
                flag = false;
            }
            return flag;
        }
    }
}
