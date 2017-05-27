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
        public void DeleteCard(Card carta) {
            if (CheckDelete(carta)) {
                dbConteirner.Card.Remove(carta);
                dbConteirner.SaveChanges();
            }else {
                MessageBox.Show("Esta carta está associoado a um baralho!\n" +
                   "Apenas poderá se eliminado caso não existam associações a nenhum baralho!", "Cartas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private bool CheckDelete(Card carta) {
            bool flag = true;
            List<Deck> listaBaralho = (from deck in dbConteirner.Deck
                                       where deck.Cards.Any(cart => cart.Id == carta.Id)
                                       select deck).ToList();
            if (listaBaralho.Count > 0) {
                flag = false;
            }
            return flag;
        }
    }
}
