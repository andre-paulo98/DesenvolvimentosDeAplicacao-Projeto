using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class EquipasRepository {
        private Modelo_Container dbContainer;
        private List<Team> listaEquipas;

        public EquipasRepository(Modelo_Container dbContainer) {
            this.dbContainer = dbContainer;
            listaEquipas = new List<Team>();
        }

        public void novaEquipa(Team equipa) {
            if(checkEquipa(equipa)) {
                dbContainer.Team.Add(equipa);
                dbContainer.SaveChanges();
            }
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

        public List<Team> getTeamsList() {
            return dbContainer.Team.ToList();
        }
    }
}
