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
    public partial class formLogin : Form {

        Modelo_Container dbContainer = new Modelo_Container();
        formPrincipal formPrincipal;
        ArbitroRepository arbitroRepos;
        AdminRepository adminRepos;
        List<Referee> arbitroLogin;
        List<Administrador> adminLogin;
        formTorneios formTorneios;
        public formLogin()
        {
            InitializeComponent();
            formPrincipal = new formPrincipal(dbContainer);
            arbitroRepos = new ArbitroRepository(dbContainer);
            adminRepos = new AdminRepository(dbContainer);
            arbitroLogin = new List<Referee>();
            adminLogin = new List<Administrador>();
            
        }

        private void btLogin_Click(object sender, EventArgs e) {
            btLogin.Text = "Aguarde...";
            btLogin.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            string username = tbUtilizador.Text;
            string password = tbPassword.Text;

            arbitroLogin = (
                from arbitro in arbitroRepos.GetRefereeList()
                where arbitro.Username == username && arbitro.Password == password
                select arbitro
                ).OfType<Referee>().ToList();//Pesquisa por arbitro na base de dados

            adminLogin = (
                from admin in adminRepos.GetAdminList()
                where admin.Username == username && admin.Password == password
                select admin
                ).OfType<Administrador>().ToList();//Pesquisa por administrador na base de dados

            if (arbitroLogin.Count == 1)//Verifica se é arbitro
            {
                formTorneios = new formTorneios(dbContainer, arbitroLogin.First());
                formTorneios.Show();
                Hide();
            }
            else if (adminLogin.Count == 1)
            {
                formPrincipal.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou password incorretos!", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btLogin.Text = "Login";
                btLogin.Enabled = true;
            }
        }
    }
}
