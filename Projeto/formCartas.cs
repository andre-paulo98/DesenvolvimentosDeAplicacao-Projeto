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
    public partial class formCartas : Form {

        private CardRepository cardRepo;
        private Boolean flagEditar;
        public formCartas() {
            InitializeComponent();
            RefreshView();
        }

        private void tbSearch_GotFocus(object sender, EventArgs e) {
            if (tbSearch.Text == "Procurar ...") {
                tbSearch.Text = "";
                tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void tbSearch_LostFocus(object sender, EventArgs e) {
            if (tbSearch.Text == "") {
                tbSearch.Text = "Procurar ...";
                tbSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                //TODO Search
            }
        }

        private void btNova_Click(object sender, EventArgs e) {
            AtivarFormulario(true);
            flagEditar = false;
        }

        private void btEditar_Click(object sender, EventArgs e) {
            Card carta = new Card();
            carta.Name = tbNome.Text;
            carta.Faction = cbFacao.Text;
            carta.Type = cbTipo.Text;
            carta.Cost = nudCusto.Value + "€";
            carta.Rules = rtbRegras.Text;
            carta.Loyalty = (short)nudLealdade.Value;
            carta.Attack = (short)nudAtaque.Value;
            carta.Defense = (short)nudDefesa.Value;
            if (flagEditar) {

            } else {
                cardRepo = new CardRepository();
                cardRepo.NovaCarta(carta);
                AtivarFormulario(false);
                RefreshView();
            }
        }

        private void btApagar_Click(object sender, EventArgs e) {
            if (flagEditar) {
                //TODO apagar carta
            }
        }

        private void lbCartas_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbCartas.SelectedIndex >= 0) {
                cardRepo = new CardRepository();
                int cartaId = int.Parse(lbCartas.Items[lbCartas.SelectedIndex].ToString().Split('-')[0].Trim());
                Card carta = cardRepo.GetCard(cartaId);
                PreencheForm(carta);
                pnBotoes.Enabled = true;
                flagEditar = true;
                AtivarFormulario(true);
            } else {
                pnBotoes.Enabled = false;
                flagEditar = false;
            }
        }

        private void AtivarFormulario(Boolean Enable) {
            pnCarta.Enabled = Enable;
            pnBotoes.Enabled = Enable;
            if (Enable) {
                btEditar.Text = "Guardar";
                btApagar.Text = "Cancelar";
            } else {
                btEditar.Text = "Editar";
                btApagar.Text = "Eliminar";
            }
            
        } 

        private void RefreshView() {
            cardRepo = new CardRepository();
            lbCartas.Items.Clear();
            foreach (Card carta in cardRepo.CardList()) {
                lbCartas.Items.Add(carta.Id+" - "+carta.Name + " - " + carta.Cost);
            }
        }

        private void PreencheForm(Card carta) {
            tbNome.Text = carta.Name;
            cbFacao.Text = carta.Faction;
            cbTipo.Text = carta.Type;
            nudCusto.Value = Decimal.Parse(carta.Cost.Replace("€", "").Trim());
            rtbRegras.Text = carta.Rules;
            nudLealdade.Value = carta.Loyalty;
            nudAtaque.Value = carta.Attack;
            nudDefesa.Value = carta.Defense;
        }

       
    }
}
