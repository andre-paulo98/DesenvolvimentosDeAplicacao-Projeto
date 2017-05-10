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
    public partial class formBaralhos : Form {

        DeckRepository deckRepo;
        CardRepository cardRepo;
        Modelo_Container dbContainer;

        public formBaralhos(Modelo_Container dbContainer) {
            InitializeComponent();
            this.dbContainer = dbContainer;
            deckRepo = new DeckRepository(dbContainer);
            cardRepo = new CardRepository(dbContainer);
            RefreshDeckList();
        }

        private void lbBaralhos_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbBaralhos.SelectedIndex >= 0) {
                label3.Visible = false;
                LoadCardList(GetSelectedDeck());
                lbCartas.Visible = true;
            } else {
                DisableCardsList();
            }
        }

        private void btNovo_Click(object sender, EventArgs e) {
            formBaralhosManipula formManipula = new formBaralhosManipula(dbContainer);
            formManipula.FormClosing += (object formSender, FormClosingEventArgs fromE) => {
                RefreshDeckList();
            };
            /*(object formSender, FormClosingEventArgs fromE) => { RefreshDeckList(); };
                * É um expresão Lambda para:
                * new FormClosingEventHandler(delegate (object formSender, FormClosingEventArgs fromE) { RefreshDeckList(); });
                * **/
            formManipula.ShowDialog(this);
        }

        private void btEliminar_Click(object sender, EventArgs e) {
            deckRepo.DeleteDeck(lbBaralhos.SelectedIndex);
            RefreshDeckList();
            DisableCardsList();
        }

        private void lbBaralhos_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lbBaralhos.SelectedIndex >= 0) {
                formBaralhosManipula formManipula = new formBaralhosManipula(GetSelectedDeck(), dbContainer);
                formManipula.FormClosing += (object formSender, FormClosingEventArgs fromE) => {
                    RefreshDeckList();
                };
                formManipula.ShowDialog(this);
                DisableCardsList();
            }
        }
        /// <summary>
        /// Função reponsavel por recarregar a lista de baralhos
        /// </summary>
        private void RefreshDeckList() {
            lbBaralhos.Items.Clear();
            foreach (Deck deck in deckRepo.GetDecksList()) {
                lbBaralhos.Items.Add(deck.Name + "\t" + deck.Cards.Count + " Carta(s)");
            }
        }
        /// <summary>
        /// Função que carrega as cartas de cada baralho na lista
        /// </summary>
        private void LoadCardList(Deck deck) {
            lbCartas.Items.Clear();
            foreach(Card card in deck.Cards) {
                lbCartas.Items.Add(card.Name + "\t" + card.Type + "\t" + card.Faction);
            }
        }
        /// <summary>
        /// Função que obtem o baralho selecionado na lista
        /// </summary>
        private Deck GetSelectedDeck() {
            return deckRepo.GetDeck(lbBaralhos.SelectedIndex);
        }
        /// <summary>
        /// Função que desativa a lista das cartas
        /// </summary>
        private void DisableCardsList() {
            label3.Visible = true;
            lbCartas.Visible = false;
            lbBaralhos.SelectedIndex = -1;
        }
    }
}
