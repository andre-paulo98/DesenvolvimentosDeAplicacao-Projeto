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
        public formBaralhos() {
            InitializeComponent();
            deckRepo = new DeckRepository();
            RefreshDeckList();
        }

        private void lbBaralhos_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbBaralhos.SelectedIndex >= 0) {
                label3.Visible = false;
                lbCartas.Visible = true;
            }else {
                label3.Visible = true;
                lbCartas.Visible = false;
            }
        }

        private void btNovo_Click(object sender, EventArgs e) {
            new formBaralhosManipula().Show();
        }

        private void lbBaralhos_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lbBaralhos.SelectedIndex >= 0) {
                Deck n = new Deck();
                n.Name = "Teste";
                new formBaralhosManipula(n).Show();
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
        private void RefreshCardList() {

        }
    }
}
