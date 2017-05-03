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
        public formBaralhosManipula(Modelo_Container dbContainer) {
            FlagEdicao = false;
            InitializeComponent();
            this.Text = "Novo Baralho";
            baralho = new Deck();
            tbNome.Visible = true;
            deckRepo = new DeckRepository(dbContainer);
            cardRepo = new CardRepository(dbContainer);
            RefreshCartasDisponiveis();
        }
        /// <summary>
        /// Formulario para editar um baralho
        /// </summary>
        /// <param name="baralho">Baralho a editar</param>
        public formBaralhosManipula(Deck baralho, Modelo_Container dbContainer) {
            FlagEdicao = true;
            InitializeComponent();
            this.Text = "Editar Baralho";
            this.baralho = baralho;
            lbNome.Text = "Baralho " + baralho.Name;
            deckRepo = new DeckRepository(dbContainer);
            cardRepo = new CardRepository(dbContainer);
            RefreshCartasDisponiveis();
            RefreshCartasBaralho();
        }
        
        private void btGuardar_Click(object sender, EventArgs e) {
            if (FlagEdicao) {//Se estiver em modo de ediçao

            } else {
                if (lbBaralho.Items.Count > 0) {
                    baralho.Name = tbNome.Text;
                    deckRepo.AddDeck(baralho);
                } else {
                    MessageBox.Show( "Nenhuma carta encontrada no baralho\n"+
                                    "Por favor adicione cartas ao baralho!",
                                    "Nenhuma carta no Baralho", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e) {

        }

        private void btAdicionar_Click(object sender, EventArgs e) {
            if (lbDisponiveis.SelectedIndex >= 0) {
                int cartaId = int.Parse(lbDisponiveis.Items[lbDisponiveis.SelectedIndex].ToString().Split('-')[0].Trim());
                baralho.Cards.Add(cardRepo.GetCard(cartaId));
                RefreshCartasBaralho();
                RefreshCartasDisponiveis();
            }
        }

        private void btRemover_Click(object sender, EventArgs e) {
            if (lbBaralho.SelectedIndex >= 0) {
                int cartaId = int.Parse(lbBaralho.Items[lbBaralho.SelectedIndex].ToString().Split('-')[0].Trim());
                baralho.Cards.Remove(cardRepo.GetCard(cartaId));
                RefreshCartasBaralho();
                RefreshCartasDisponiveis();
            }
        }
        /// <summary>
        /// Carrega as cartas na listBox BARALHO
        /// </summary>
        /// 
        private void RefreshCartasBaralho() {
            lbBaralho.Items.Clear();
            foreach (Card card in baralho.Cards) {
                lbBaralho.Items.Add(card.Id+" - "+card.Name);
            }
        }
        /// <summary>
        /// Carrega as cartas na listBox DISPONIVEIS
        /// </summary>
        private void RefreshCartasDisponiveis() {
            lbDisponiveis.Items.Clear();
            foreach (Card card in cardRepo.GetCardsListNotIn(baralho.Cards.Cast<Card>().ToList())) {
                lbDisponiveis.Items.Add(card.Id+" - "+card.Name);
            }
        }       
    }
}
