using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto {
    class DeckRepository {
        private Modelo_Container dbConteirner;

        public DeckRepository() {
            dbConteirner = new Modelo_Container();
        }

        public List<Deck> DeckList() {
            List<Deck> DeckList = dbConteirner.Deck.ToList();
            return DeckList;
        }
    }
}
