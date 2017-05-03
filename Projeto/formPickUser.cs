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
    public partial class formPickUser : Form
    {
        Modelo_Container dbContainer;
        public formPickUser(Modelo_Container dbContainer)
        {
            this.dbContainer = dbContainer;
            InitializeComponent();
        }

        private void clickGestaoArbritos(object sender, EventArgs e)
        {
            formUserReferee arbritos = new formUserReferee(dbContainer);
            arbritos.Show();
            Hide();
        }
    }
}
