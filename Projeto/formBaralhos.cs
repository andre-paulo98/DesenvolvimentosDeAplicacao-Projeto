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
            formManipula.FormClosing += (object formSender, FormClosingEventArgs fromE) => { RefreshDeckList(); };
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
                new formBaralhosManipula(GetSelectedDeck(), dbContainer).Show(this);
                DisableCardsList();
            }
        }
        /// <summary>
        /// Função reponsavel por recarregar a lista de baralhos
        /// </summary>
        private void RefreshDeckList() {
            lbBaralhos.Items.Clear();
            foreach (Deck baralho in deckRepo.GetDecksList()) {
                lbBaralhos.Items.Add(baralho.Id + " - " + baralho.Name);
            }
        }
        /// <summary>
        /// Função que carrega as cartas de cada baralho na lista
        /// </summary>
        private void LoadCardList(Deck baralho) {
            lbCartas.Items.Clear();
            foreach(Card carta in baralho.Cards) {
                lbCartas.Items.Add(carta.Id + " - " + carta.Name);
            }
        }
        /// <summary>
        /// Função que obtem o baralho selecionado na lista
        /// </summary>
        private Deck GetSelectedDeck() {
            int baralhoId = int.Parse(lbBaralhos.Items[lbBaralhos.SelectedIndex].ToString().Split('-')[0].Trim());
            return deckRepo.GetDeck(baralhoId);
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
