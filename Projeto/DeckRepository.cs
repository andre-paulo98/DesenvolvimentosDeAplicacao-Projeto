using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class DeckRepository {
        private Modelo_Container dbConteirner;
        /*Duvida de como se obtem as cartas do baralho*/
        public DeckRepository() {
            dbConteirner = new Modelo_Container();
        }
        public void DeleteDeck(Deck baralho) {
            if (DeckChecker(baralho)) {
                dbConteirner.Deck.Remove(baralho);
                dbConteirner.SaveChanges();
            }
        }

        public void AddDeck(Deck baralho) {
            if (DeckChecker(baralho)) {
                dbConteirner.Deck.Add(baralho);
                dbConteirner.SaveChanges();
            }
        }

        public void EditDeck(Deck baralho) {
            if (DeckChecker(baralho)) {
                Deck originCarta = (from Deck in dbConteirner.Deck.ToList()
                                    where Deck.Id == baralho.Id
                                    select Deck).ToList().First();
                dbConteirner.SaveChanges();
            }
        }

        public Deck GetDeck(int id) {
            Deck baralho = (from Deck in dbConteirner.Deck.ToList()
                            where Deck.Id == id
                            select Deck).ToList().First();
            return baralho;
        }
        //TODO
        /*public List<Card> GetDeckCardList(int id) {
            Deck baralho = (from Deck in dbConteirner.Deck.ToList()
                                 where Deck.Id == id
                                 select Card);
            return baralho.Cards.ToList();
        }*/

        public List<Deck> GetDeckList() {
            return dbConteirner.Deck.ToList();
        }

        private bool DeckChecker(Deck baralho) {
            bool flag = false;
            if (baralho.Name.Length == 0) {
                ErroMensagem("O campo \"Nome\" não está preenchido!");
            } else if (baralho.Cards.ToList().Count <= 0) {
                ErroMensagem("A lista de Carta não está preenchida!");
            } else if (baralho.GamesAsOne == null || baralho.GamesAsTwo == null) {
                ErroMensagem("Nenhum jogo selecionado!");
            } else {
                flag = true;
            }
            return flag;
        }

        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Baralhos - Dados Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
