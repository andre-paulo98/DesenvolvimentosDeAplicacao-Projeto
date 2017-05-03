using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class CardRepository {
        private Modelo_Container dbConteirner;

        public CardRepository(Modelo_Container dbConteirner) {
            this.dbConteirner = dbConteirner;
        }

        public bool AddCard(Card carta) {
            bool flag = CardChecker(carta);
            if (flag) {
                dbConteirner.Card.Add(carta);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool EditCard(Card carta) {
            bool flag = (CardChecker(carta) && carta.Id != 0);
            if (flag) {
                Card cartaLista = (from Card in dbConteirner.Card.ToList()
                                   where Card.Id == carta.Id
                 select Card).First();
                cartaLista = carta;
                Card originCarta = (from Card in dbConteirner.Card.ToList()
                                    where Card.Id == carta.Id
                                    select Card).First();
                originCarta = carta;
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool DeleteCard(int cartaId) {
            Card tempCart = dbConteirner.Card.ToList().ElementAt(cartaId);
            bool flag = CardChecker(tempCart);
            if (flag) {
                dbConteirner.Card.ToList().RemoveAt(cartaId);
                dbConteirner.Card.Remove(tempCart);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public Card GetCard(int id) {
            Card carta = (from Card in dbConteirner.Card.ToList()
                          where Card.Id == id
                          select Card).ToList().First();
            return carta;
        }

        public List<Card> GetCardsList() {
            return dbConteirner.Card.ToList();
        }

        public List<Card> GetCardsListNotIn(List<Card> cartas) {
            return (from card in dbConteirner.Card.ToList()
                           where !(cartas.Contains(card))
                           select card).ToList();
        }

        public List<Card> SearchCard(string nome) {
            return (from Card in dbConteirner.Card.ToList()
                           where Card.Name.ToUpper().Contains(nome.ToUpper())
                           select Card).ToList();
        }

        private bool CardChecker(Card carta) {
            bool flag = false;
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
            } else {
                flag = true;
            }
            return flag;
        }

        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Cartas - Dados Invalidos",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
