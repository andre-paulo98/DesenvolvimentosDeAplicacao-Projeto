using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto {
    class EquipasRepository {
        private Modelo_Container dbContainer;
        private List<Team> listaTorneios;

        public EquipasRepository(Modelo_Container dbContainer) {
            this.dbContainer = dbContainer;
            listaTorneios = new List<Team>();
        }
    }
}
