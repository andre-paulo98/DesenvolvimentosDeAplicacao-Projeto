using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class DeckRepository {

        private Modelo_Container dbConteirner;

        public DeckRepository(Modelo_Container dbConteirner) {
            this.dbConteirner = dbConteirner;
        }

        public bool AddDeck(Deck baralho) {
            bool flag = DeckChecker(baralho);
            if (flag) {
                dbConteirner.Deck.Add(baralho);
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        
        public bool EditDeck(Deck baralho) {
            bool flag = DeckChecker(baralho);
            if (flag) {
                dbConteirner.SaveChanges();
            }
            return flag;
        }

        public void DeleteDeck(int pos) {
            dbConteirner.Deck.Remove(GetDeck(pos));
            dbConteirner.SaveChanges();
        }

        public Deck GetDeck(int pos) {
            Deck baralho = dbConteirner.Deck.ToList().ElementAt(pos);
            return baralho;
        }

        public List<Deck> GetDecksList() {
            return dbConteirner.Deck.ToList();
        }

        public List<Card> GetDeckCardList(int pos) {
            List<Card> cartas = GetDeck(pos).Cards.Cast<Card>().ToList();
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
