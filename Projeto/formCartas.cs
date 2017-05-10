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
        private List<Card> cardList;

        public formCartas(Modelo_Container dbContainer) {
            InitializeComponent();
            cardRepo = new CardRepository(dbContainer);
            RefreshView();
            cbFacao.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
        }

        private void tbSearch_GotFocus(object sender, EventArgs e) {
            if (tbSearch.Text == "Nome da Carta ...") {
                tbSearch.Text = "";
                tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void tbSearch_LostFocus(object sender, EventArgs e) {
            if (tbSearch.Text == "") {
                ResetSearch();
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btPesquisa.PerformClick();
            }
        }

        private void btNova_Click(object sender, EventArgs e) {
            LimpaForm();
            flagEditar = false;
            AtivarFormulario(true);
        }

        private void btEditar_Click(object sender, EventArgs e) {
            Card carta;
            if (flagEditar) {
                carta = cardList.ElementAt(lbCartas.SelectedIndex);
            } else {
                carta = new Card();
            }
            carta.Name = tbNome.Text;
            carta.Faction = cbFacao.Text;
            carta.Type = cbTipo.Text;
            carta.Cost = tbCusto.Text;
            carta.Rules = rtbRegras.Text;
            carta.Loyalty = (short)nudLealdade.Value;
            carta.Attack = (short)nudAtaque.Value;
            carta.Defense = (short)nudDefesa.Value;
            if (flagEditar) {
                if (cardRepo.EditCard(carta)) {
                    LimpaForm();
                    flagEditar = false;
                    ResetSearch();
                    RefreshView();
                    LimpaForm();
                    AtivarFormulario(false);
                }
            } else {
                if (cardRepo.AddCard(carta)) {
                    ResetSearch();
                    RefreshView();
                    LimpaForm();
                    AtivarFormulario(false);
                }
            }
        }

        private void btApagar_Click(object sender, EventArgs e) {
            if (flagEditar) {
                cardRepo.DeleteCard(cardList.ElementAt(lbCartas.SelectedIndex));
                RefreshView();
            }
            LimpaForm();
            flagEditar = false;
            AtivarFormulario(false);
        }

        private void btPesquisa_Click(object sender, EventArgs e) {
            if (tbSearch.Text != null) {
                LimpaForm();
                AtivarFormulario(false);
                lbCartas.Items.Clear();
                cardList = cardRepo.SearchCard(tbSearch.Text);
                foreach (Card carta in cardList) {
                    lbCartas.Items.Add(carta.Name + "\t" + carta.Type + "\t" + carta.Faction);
                }
            }
        }

        private void btSearchClear_Click(object sender, EventArgs e) {
            RefreshView();
            ResetSearch();
            LimpaForm();
            AtivarFormulario(false);

        }

        private void lbCartas_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbCartas.SelectedIndex >= 0) {
                PreencheForm(cardList.ElementAt(lbCartas.SelectedIndex));
                flagEditar = true;
                AtivarFormulario(true);
            }
        }
        /// <summary>
        /// Funçao que ativa ou desativa o formulario da carta
        /// </summary>
        /// <param name="Enable"></param>
        private void AtivarFormulario(Boolean Enable) {
            pnCarta.Enabled = Enable;
            pnBotoes.Enabled = Enable;
            if (flagEditar) {
                btEditar.Text = "Guardar Edição";
                btApagar.Text = "Eliminar";
            } else {
                btEditar.Text = "Guardar";
                btApagar.Text = "Cancelar";
            }
            
        } 
        /// <summary>
        /// Funcao que carrega as cartas na lista
        /// cada vez que esta sofre alteraçoes
        /// </summary>
        private void RefreshView() {
            cardList = cardRepo.GetCardsList();
            lbCartas.Items.Clear();
            foreach (Card carta in cardList) {
                lbCartas.Items.Add(carta.Name + "\t" + carta.Type + "\t"+carta.Faction);
            }
        }
        /// <summary>
        /// Funcao que preenche o formulario da carta com os dados da carta
        /// </summary>
        /// <param name="carta"></param>
        private void PreencheForm(Card carta) {
            tbNome.Text = carta.Name;
            cbFacao.Text = carta.Faction;
            cbTipo.Text = carta.Type;
            tbCusto.Text = carta.Cost;
            rtbRegras.Text = carta.Rules;
            nudLealdade.Value = carta.Loyalty;
            nudAtaque.Value = carta.Attack;
            nudDefesa.Value = carta.Defense;
        }
        /// <summary>
        /// Funcao que limpa os dados do formulario
        /// </summary>
        private void LimpaForm() {
            tbNome.Text = "";
            cbTipo.SelectedIndex = 0;
            cbFacao.SelectedIndex = 0;
            rtbRegras.Text = "";
            nudAtaque.Value = 0;
            tbCusto.Text = "";
            nudDefesa.Value = 0;
            nudLealdade.Value = 0;
            lbCartas.SelectedIndex = -1;
        }
        
        /// <summary>
        /// Funcao que limpa a barra de pesquisa
        /// </summary>
        private void ResetSearch() {
            tbSearch.Text = "Nome da Carta ...";
            tbSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
        }

        private void nudLealdade_ValueChanged(object sender, EventArgs e) {

        }
    }
}
