using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class DeckRepository {

        private Modelo_Container dbConteirner;
        private List<Deck> listaBaralhos;

        public DeckRepository(Modelo_Container dbConteirner) {
            this.dbConteirner = dbConteirner;
            listaBaralhos = new List<Deck>();
        }

        public bool AddDeck(Deck baralho) {
            bool flag = DeckChecker(baralho);
            if (flag) {
                listaBaralhos.Add(baralho);
                dbConteirner.Deck.Add(baralho);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        //TODO Refazer esta função
        public bool EditDeck(Deck baralho) {
            bool flag = DeckChecker(baralho);
            if (flag) {
                Deck originCarta = (from Deck in dbConteirner.Deck.ToList()
                                    where Deck.Id == baralho.Id
                                    select Deck).ToList().First();
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public bool DeleteDeck(int baralhoId) {
            Deck tempBaralho = listaBaralhos.ElementAt(baralhoId);
            bool flag = DeckChecker(tempBaralho);
            if (flag) {
                listaBaralhos.Remove(tempBaralho);
                dbConteirner.Deck.Remove(tempBaralho);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public Deck GetDeck(int id) {
            Deck baralho = (from Deck in dbConteirner.Deck.ToList()
                            where Deck.Id == id
                            select Deck).ToList().First();
            return baralho;
        }

        public List<Deck> GetDecksList() {
            listaBaralhos = dbConteirner.Deck.ToList();
            return listaBaralhos;
        }

        public List<Card> GetDeckCardList(int deckId) {
            List<Card> cartas = (from deck in dbConteirner.Deck.ToList()
                                 where deck.Id == deckId
                                 select deck.Cards).Cast<Card>().ToList();
            return cartas;
        }

        private bool DeckChecker(Deck baralho) {
            bool flag = false;
            if (baralho.Name.Length == 0) {
                ErroMensagem("O campo \"Nome\" não está preenchido!");
            } else if (baralho.Cards.Count <= 0) {
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
