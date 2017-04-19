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
        /// <summary>
        /// Formulario para adicionar um novo baralho
        /// </summary>
        public formBaralhosManipula() {
            FlagEdicao = false;
            InitializeComponent();
            tbNome.Visible = true;
        }
        /// <summary>
        /// Formulario para editar um baralho
        /// </summary>
        /// <param name="baralho">Baralho a editar</param>
        public formBaralhosManipula(Deck baralho) {
            FlagEdicao = true;
            InitializeComponent();
            this.baralho = baralho;
            lbNome.Text = "Baralho " + baralho.Name;
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

        }
    }
}
