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
            cardRepo = new CardRepository();
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
            ativarFormulario(true);
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
                cardRepo.NovaCarta(carta);
                ativarFormulario(true);
                RefreshView();
            }
        }








        private void ativarFormulario(Boolean Enable) {
            tbNome.Enabled = Enable;
            cbTipo.Enabled = Enable;
            cbFacao.Enabled = Enable;
            rtbRegras.Enabled = Enable;
            nudAtaque.Enabled = Enable;
            nudDefesa.Enabled = Enable;
            nudCusto.Enabled = Enable;
            btEditar.Enabled = Enable;
            if (Enable) {
                btEditar.Text = "Guardar";
            } else {
                btEditar.Text = "Editar";
            }
            
        }

        private void vistaEditarCarta() {
            tbNome.Enabled = true;
            cbTipo.Enabled = true;
            cbFacao.Enabled = true;
            rtbRegras.Enabled = true;
            nudAtaque.Enabled = true;
            nudDefesa.Enabled = true;
            nudCusto.Enabled = true;
            btEditar.Text = "Editar";
        }

        private void RefreshView() {
            lbCartas.Items.Clear();
            foreach (Card carta in cardRepo.CardList()) {
                lbCartas.Items.Add(carta.Id+" - "+carta.Name + " - " + carta.Cost);
            }
        }

        private void LoadForm(int CardId) {

        }

        private void lbCartas_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbCartas.SelectedIndex >=0) {

            }
        }
    }
}
