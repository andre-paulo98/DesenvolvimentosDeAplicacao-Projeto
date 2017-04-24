using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class CardRepository {
        private Modelo_Container dbConteirner;

        private List<Card> cardList;


        public CardRepository() {
            dbConteirner = new Modelo_Container();
            cardList = dbConteirner.Card.ToList();
        }

        public void NovaCarta(Card carta) {
            if (carta.Name.Length == 0) {
                ErroMensagem("O campo \"Nome\" não está preenchido!");
            } else if (carta.Faction.Length == 0) {
                ErroMensagem("O campo \"Fação\" não está preenchido!");
            } else if (carta.Type.Length == 0) {
                ErroMensagem("O campo \"Tipo de Carta\" não está preenchido!");
            } else if (carta.Cost.Length == 0) {
                ErroMensagem("O valor do campo \"Custo\" não é valido!");
            } else if (carta.Loyalty < 0) {
                ErroMensagem("O valor do campo \"Lealdade\" não é valido!");
            } else if (carta.Rules.Length == 0) {
                ErroMensagem("O Campo \"Regras\" não está preenchido!");
            } else if (carta.Attack < 0) {
                ErroMensagem("O valor do campo \"Ataque\" não é valido!");
            } else if (carta.Defense < 0) {
                ErroMensagem("O valor do campo \"Defesa\" não é valido!");
            }else {
                dbConteirner.Card.Add(carta);
                dbConteirner.SaveChanges();
            }
        }

        public void EditCard(Card editedCard) {
            
        }

        public Card GetCard(int idCarta) {
            Card carta = ( from Card in cardList
                         where Card.Id == idCarta
                           select Card).ToList().First();
            return carta;
        }

        public List<Card> CardList() {
            return cardList;
        }

        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Cartas - Dados Invalidos",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
