using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto {
    class CardRepository {
        private Modelo_Container dbConteirner;

        public CardRepository() {
            dbConteirner = new Modelo_Container();
        }

        public List<Card> CardList() {
            List<Card> CardList = dbConteirner.Card.ToList();
            return CardList;
        }
    }
}
