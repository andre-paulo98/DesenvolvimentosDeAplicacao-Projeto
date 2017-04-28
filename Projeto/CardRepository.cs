using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class CardRepository {
        private Modelo_Container dbConteirner;
        private List<Card> listaCartas;

        public CardRepository() {
            dbConteirner = new Modelo_Container();
            listaCartas = new List<Card>();
        }

        public void DeleteCard(Card carta) {
            if (CardChecker(carta)) {
                listaCartas.Remove(carta);
                dbConteirner.Card.Remove(carta);
                dbConteirner.SaveChanges();
            }
        }

        public void AddCard(Card carta) {
            if (CardChecker(carta)) {
                listaCartas.Add(carta);
                dbConteirner.Card.Add(carta);
                dbConteirner.SaveChanges();
            }
        }
        //TODO Refazer esta função
        /*Duvida de como se edita um objeto*/
        public void EditCard(Card carta) {
            if (CardChecker(carta)) {
                Card cartaLista = (from Card in listaCartas
                 where Card.Id == carta.Id
                 select Card).First();
                cartaLista = carta;
                Card originCarta = (from Card in dbConteirner.Card.ToList()
                                    where Card.Id == carta.Id
                                    select Card).First();
                originCarta = carta;
                dbConteirner.SaveChanges();
            }
        }

        public List<Card> GetListCards() {
            listaCartas = dbConteirner.Card.ToList();
            return listaCartas;
        }

        public Card GetCard(int id) {
            Card carta = (from Card in dbConteirner.Card.ToList()
                          where Card.Id == id
                          select Card).ToList().First();
            return carta;
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
