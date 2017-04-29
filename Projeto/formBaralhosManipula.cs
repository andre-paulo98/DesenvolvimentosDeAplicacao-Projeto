using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    public partial class formBaralhosManipula : Form {

        private Deck baralho;
        private Boolean FlagEdicao;
        private DeckRepository deckRepo;
        private CardRepository cardRepo;
        /// <summary>
        /// Formulario para adicionar um novo baralho
        /// </summary>
        public formBaralhosManipula() {
            FlagEdicao = false;
            InitializeComponent();
            this.Text = "Novo Baralho";
            tbNome.Visible = true;
            deckRepo = new DeckRepository();
            cardRepo = new CardRepository();
        }
        /// <summary>
        /// Formulario para editar um baralho
        /// </summary>
        /// <param name="baralho">Baralho a editar</param>
        public formBaralhosManipula(Deck baralho) {
            FlagEdicao = true;
            InitializeComponent();
            this.Text = "Editar Baralho";
            this.baralho = baralho;
            lbNome.Text = "Baralho " + baralho.Name;
            deckRepo = new DeckRepository();
            cardRepo = new CardRepository();
        }
        
        private void btGuardar_Click(object sender, EventArgs e) {
            if (FlagEdicao) {//Se estiver em modo de ediçao

            } else {
                /*DUVIDA - Como adicionar as cartas ao baralho*/
                Deck novoBaralho = new Deck();
                novoBaralho.Name = tbNome.Text;
                deckRepo.AddDeck(novoBaralho);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e) {

        }

        private void btAdicionar_Click(object sender, EventArgs e) {

        }

        private void btRemover_Click(object sender, EventArgs e) {

        }
        //TODO Obter Cartas do Baralho e colocalas na lista
        /// <summary>
        /// Carrega as cartas na listBox BARALHO
        /// </summary>
        /// 
        private void RefreshCartasBaralho() {

        }
        /// <summary>
        /// Carrega as cartas na listBox DISPONIVEIS
        /// </summary>
        private void RefreshCartasDisponiveis() {
            foreach (Card card in cardRepo.GetCardsList()) {
                lbDisponiveis.Items.Add(card.Name);
            }
        }       
    }
}
