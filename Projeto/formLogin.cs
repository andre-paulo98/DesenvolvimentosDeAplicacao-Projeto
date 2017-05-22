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
        UserRepository userRepo;
        public formLogin() {
            InitializeComponent();
            formPrincipal = new formPrincipal(dbContainer);
            userRepo = new UserRepository(dbContainer);
        }

        private void btLogin_Click(object sender, EventArgs e) {
            btLogin.Text = "Aguarde...";
            btLogin.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            string username = tbUtilizador.Text;
            string password = tbPassword.Text;
            List<User> userLogado = (
                from user in userRepo.UserList()
                where user.Username == username && user.Password == password
                select user
                ).ToList();//Pesquisa pelo utilizador na base de dados
            //Verifica se utilizador existe
            if (userLogado.Count == 1) {
                formPrincipal.Show();
                Hide();
            } else {
                MessageBox.Show("Nome de utilizador ou password incorretos!", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btLogin.Text = "Login";
                btLogin.Enabled = true;
            }
        }
    }
}
