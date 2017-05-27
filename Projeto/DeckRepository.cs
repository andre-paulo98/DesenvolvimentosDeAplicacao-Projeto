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
            if (CheckDelete(GetDeck(pos))) {
                dbConteirner.Deck.Remove(GetDeck(pos));
                dbConteirner.SaveChanges();
            }else {
                MessageBox.Show("Este Baralho está associoado a um jogo!\n" +
                    "Apenas poderá se eliminado caso não existam associações a nenhumo jogo!", "Baralho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        public bool CheckDelete(Deck baralho) {
            bool flag = true;
            List<Game> listaJogos = (from game in dbConteirner.Game
                                     where game.DeckOne.Id == baralho.Id ||
                                     game.DeckTwo.Id == baralho.Id
                                     select game).ToList();
            if (listaJogos.Count > 0) {
                flag = false;
            }

            return flag;
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
