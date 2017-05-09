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
    public partial class formUserAdmin : Form
    {
        private Modelo_Container dbContainer;
        public formUserAdmin(Modelo_Container container)
        {
            InitializeComponent();
            this.dbContainer = container;
        }

        private void btAddNovo_Click(object sender, EventArgs e)
        {
            formAdicionarAdmin addAdmin = new formAdicionarAdmin(this, dbContainer);
            addAdmin.ShowDialog(this);
        }
    }
}
