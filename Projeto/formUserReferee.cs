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
        }

        private void clickAddArbrito(object sender, EventArgs e)
        {
            formAdicionarArbrito addArbrito = new formAdicionarArbrito(this, dbContainer);
            addArbrito.Show();
            Hide();
        }
        private void RefreshView()
        {
            lbArbitros.Items.Clear();

            foreach (Referee arbitro in arbitroRepos.GetRefereeList())
            {
                lbArbitros.Items.Add(arbitro.Id + " - " + arbitro.Name);//Lista de arbitos
            }
        }
    }
}
