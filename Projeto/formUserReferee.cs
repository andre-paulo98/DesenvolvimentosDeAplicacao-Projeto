using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class formUserReferee : Form
    {
        private ArbitroRepository arbitroRepos;
        private Modelo_Container dbContainer;
        private List<Referee> arbitroList;
        private Referee currentReferee;
        public formUserReferee(Modelo_Container dbContainer)
        {
            InitializeComponent();
            this.dbContainer = dbContainer;
            arbitroRepos = new ArbitroRepository(dbContainer);
            RefreshView();//refresh da lista de arbitros
            btEditar.Hide();
        }

        private void clickAddArbrito(object sender, EventArgs e)
        {
            formAdicionarArbrito addArbrito = new formAdicionarArbrito(this, dbContainer);
            addArbrito.FormClosing += new FormClosingEventHandler(formUserReferee_FormClosing); // *1*
            addArbrito.ShowDialog(this);
        }

        private void RefreshView() // método para refresh da lista de arbitros
        {
            arbitroList = arbitroRepos.GetRefereeList();
            lbArbitros.Items.Clear();
            btEditar.Hide();
            foreach (Referee arbitro in arbitroList)
            {
                lbArbitros.Items.Add(arbitro.Id + " - " + arbitro.Name);//Lista de arbitos
            }
        }

        private void formUserReferee_FormClosing(object sender, FormClosingEventArgs e)//atualiza a lb quando o adicionar arbitro fecha. *1*
        {
            RefreshView();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (lbArbitros.SelectedIndex != -1)
            {
                arbitroRepos.DeleteReferee(arbitroList.ElementAt(lbArbitros.SelectedIndex));//remover arbitro com o metodo DeleteReferee no arbitro repos
                RefreshView();
            }
            
        }

        private void btPesquisaArbrito_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != null)
            {
                arbitroList = arbitroRepos.SearchArbitro(tbSearch.Text);
                lbArbitros.Items.Clear();
                btEditar.Hide();
                foreach (Referee arbitro in arbitroRepos.SearchArbitro(tbSearch.Text))//pesquisar o arbitro com o metodo searchArbitro no arbitro repos
                {
                    lbArbitros.Items.Add(arbitro.Id+ " - " + arbitro.Name);
                }
            }
        }

        private void lbArbitros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbArbitros.SelectedIndex != -1)
            {
                btEditar.Show(); //Aparecer o botão de editar quando é selecionado algum nome
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            currentReferee = arbitroList.ElementAt(lbArbitros.SelectedIndex);
            formAdicionarArbrito EditArbitro = new formAdicionarArbrito(this, dbContainer,currentReferee);//editar a true muda o form de forma
            EditArbitro.FormClosing += new FormClosingEventHandler(formUserReferee_FormClosing);
            EditArbitro.ShowDialog(this);
        }
    }
}
