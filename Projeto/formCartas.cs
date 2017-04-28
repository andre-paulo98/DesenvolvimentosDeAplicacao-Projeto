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
            LimpaForm();
            flagEditar = false;
            AtivarFormulario(true);
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
                cardRepo = new CardRepository();
                cardRepo.EditCard(carta);
            } else {
                cardRepo = new CardRepository();
                cardRepo.AddCard(carta);
            }
            flagEditar = false;
            AtivarFormulario(false);
            RefreshView();
        }

        private void btApagar_Click(object sender, EventArgs e) {
            if (flagEditar) {
                //TODO apagar carta
            }
            LimpaForm();
            flagEditar = false;
            AtivarFormulario(false);
        }

        private void lbCartas_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbCartas.SelectedIndex >= 0) {
                cardRepo = new CardRepository();
                int cartaId = int.Parse(lbCartas.Items[lbCartas.SelectedIndex].ToString().Split('-')[0].Trim());
                Card carta = cardRepo.GetCard(cartaId);
                PreencheForm(carta);
                flagEditar = true;
                AtivarFormulario(true);
            } else {
                flagEditar = false;
                AtivarFormulario(false);
            }
        }

        private void AtivarFormulario(Boolean Enable) {
            pnCarta.Enabled = Enable;
            pnBotoes.Enabled = Enable;
            if (flagEditar) {
                btEditar.Text = "Editar";
                btApagar.Text = "Eliminar";
            } else {
                btEditar.Text = "Guardar";
                btApagar.Text = "Cancelar";
            }
            
        } 

        private void RefreshView() {
            cardRepo = new CardRepository();
            lbCartas.Items.Clear();
            foreach (Card carta in cardRepo.GetListCards()) {
                lbCartas.Items.Add(carta.Id+" - "+carta.Name + "\n\t\t" + carta.Cost);
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

        private void LimpaForm() {
            tbNome.Text = "";
            cbTipo.SelectedIndex = 0;
            cbFacao.SelectedIndex = 0;
            rtbRegras.Text = "";
            nudAtaque.Value = 0;
            nudCusto.Value = new Decimal(0.00);
            nudDefesa.Value = 0;
            nudLealdade.Value = 0;
            lbCartas.SelectedIndex = -1;
        }
    }
}
