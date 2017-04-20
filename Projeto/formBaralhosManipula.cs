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

        private void btAdd_Click(object sender, EventArgs e) {
            if (FlagEdicao) {//Se estiver em modo de ediçao

            } else {

            }
        }
        /// <summary>
        /// Carrega as cartas na listBox BARALHO
        /// </summary>
        private void carregaCartasBaralho() {

        }
        /// <summary>
        /// Carrega as cartas na listBox DISPONIVEIS
        /// </summary>
        private void carregaCartasDisponiveis() {
            foreach(Card card in cardRepo.CardList()) {
                lbDisponiveis.Items.Add(card.Name);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
