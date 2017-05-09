using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    class CardRepository {
        private Modelo_Container dbConteirner;
        private List<Card> listaCarta;

        public CardRepository(Modelo_Container dbConteirner) {
            this.dbConteirner = dbConteirner;
        }
        /// <summary>
        /// Metodo responsavel por adicionar uma carta à 
        /// base de dados
        /// </summary>
        /// <param name="carta"></param>
        /// <returns>TRUE - Se for inserida | FALSE - se não</returns>
        public bool AddCard(Card carta) { 
            bool flag = CardChecker(carta);
            if (flag) {
                dbConteirner.Card.Add(carta);
                dbConteirner.SaveChanges();
            }
            return flag;
        }
        /// <summary>
        /// Metodo responsavel por editar uma carta.
        /// Nesta carta deve constar o ID da mesma e
        /// os novos dados.
        /// </summary>
        /// <param name="carta">Carta a ser editada</param>
        /// <returns>TRUE - Se for editada | FALSE - se não</returns>
        public bool EditCard(Card carta) {
            bool flag = (CardChecker(carta));
            if (flag) {
                dbConteirner.SaveChanges();
            }
            return flag;
        }
        /// <summary>
        /// Metodo responsavel por apagar uma carta.
        /// </summary>
        /// <param name="Id da Carta"></param>
        /// <returns>TRUE - Se for eliminada | FALSE - se não</returns>
        public bool DeleteCard(Card carta) {
            bool flag = CardChecker(carta);
            foreach (Deck deck in dbConteirner.Deck){
                if(deck.Cards.ToList().Find(card => card.Id == carta.Id) != null) {
                    DialogResult result = MessageBox.Show("Esta carta está associada a um baralho!\n"+
                        "Ao eliminar esta carta vai removela de todos os baralhos!\n"+
                        "Pretende mesmo continuar?","Apagar Carta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(result == DialogResult.No) {
                        flag = false;
                    }
                }
            }

            if (flag) {
                dbConteirner.Card.Remove(carta);
                dbConteirner.SaveChanges();
            }
            return flag;
        }
        /// <summary>
        /// Metodo responsavel por obter uma carta 
        /// da base de dados
        /// </summary>
        /// <param name="CartaId">Id da carta</param>
        /// <returns>A carta</returns>
        public Card GetCard(int cartaId) {
            Card carta = dbConteirner.Card.ToList().Find(card => card.Id == cartaId);
            return carta;
        }
        /// <summary>
        /// Metodo responsavel por listar todas
        /// as cartas que estão na base de dados
        /// </summary>
        /// <returns>Lista de Cartas</returns>
        public List<Card> GetCardsList() {
            return dbConteirner.Card.ToList();
        }
        /// <summary>
        /// Metodo respondavel por listar as cartas
        /// que faltão na lista
        /// </summary>
        /// <param name="cartas"></param>
        /// <returns>Lista de cartas</returns>
        public List<Card> GetCardsListNotIn(List<Card> cartas) {
            return (from card in dbConteirner.Card.ToList()
                           where !(cartas.Contains(card))
                           select card).ToList();
        }
        /// <summary>
        /// Metodo responsavel por pesquisar
        /// cartas atravez do nome
        /// </summary>
        /// <param name="nome">Nome da carta a ser encontrada</param>
        /// <returns>Lista de Cartas encontradas</returns>
        public List<Card> SearchCard(string nome) {
            return (from Card in dbConteirner.Card.ToList()
                           where Card.Name.ToUpper().Contains(nome.ToUpper())
                           select Card).ToList();
        }
        /// <summary>
        /// Verifica se a carta esta devidamente
        /// preenchida.
        /// </summary>
        /// <param name="carta">Carta a ser verificada</param>
        /// <returns>TRUE - Se for preenchida | FALSE - se não</returns>
        private bool CardChecker(Card carta) {
            bool flag = false;
            if (carta.Name.Length == 0) {
                ErroMensagem("O campo \"Nome\" não está preenchido!");
            } else if (carta.Faction.Length == 0) {
                ErroMensagem("O selecione uma \"Fação\"!");
            } else if (carta.Type.Length == 0) {
                ErroMensagem("O selecione um \"Tipo de Carta\"!");
            } else if (carta.Cost.Length <= 0) {
                ErroMensagem("O campo \"Custo\" não está preenchido!");
            } else if (carta.Loyalty < 0) {
                ErroMensagem("O valor do campo \"Lealdade\" não é valido!\n"+
                    "A \"Lealdade\" deve ser superior a \"0\".");
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
        /// <summary>
        /// Metodo responsavel por mostrar uma mensagem
        /// de aviso de carta invalida
        /// </summary>
        /// <param name="mensage">Mensagem a ser mostrada</param>
        private void ErroMensagem(string mensage) {
            MessageBox.Show(mensage, "Cartas - Dados Invalidos",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
