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
        ArbitroRepository arbitroRepos;
        private Modelo_Container dbContainer;
        public formUserReferee(Modelo_Container dbContainer)
        {
            InitializeComponent();
            this.dbContainer = dbContainer;
            arbitroRepos = new ArbitroRepository(dbContainer);
            //refresh da lista de arbitros
            RefreshView();
        }

        private void clickAddArbrito(object sender, EventArgs e)
        {
            formAdicionarArbrito addArbrito = new formAdicionarArbrito(this, dbContainer);
            addArbrito.FormClosing += new FormClosingEventHandler(formUserReferee_FormClosing);
            addArbrito.Show();
        }

        private void RefreshView() // método para refresh da lista de arbitros
        {
            lbArbitros.Items.Clear();

            foreach (Referee arbitro in arbitroRepos.GetRefereeList())
            {
                lbArbitros.Items.Add(arbitro.Name);//Lista de arbitos
            }
        }

        private void formUserReferee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshView();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (lbArbitros.SelectedIndex != -1)
            {
                arbitroRepos.DeleteReferee(lbArbitros.SelectedIndex);
                RefreshView();
            }
            
        }

        private void btPesquisaArbrito_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != null)
            {
                lbArbitros.Items.Clear();
                foreach (Referee arbitro in arbitroRepos.SearchArbitro(tbSearch.Text))
                {
                    lbArbitros.Items.Add(arbitro.Name);
                }
            }
        }
    }
}
