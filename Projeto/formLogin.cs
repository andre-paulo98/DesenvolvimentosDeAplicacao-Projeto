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
        formPrincipal formPrincipal = new formPrincipal();
        public formLogin() {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e) {
            string username = tbUtilizador.Text;
            string password = tbPassword.Text;
            Modelo_Container dbConteirner = new Modelo_Container();
            List<User> usersList = dbConteirner.User.ToList<User>();
            Boolean flag = false;
            foreach(User utilizador in usersList) {
                if (utilizador.Username == username && utilizador.Password == password) {
                    flag = true;
                }
            }
            if (flag) {
                formPrincipal.Show();
                Hide();
            }else {
                MessageBox.Show("Nome de utilizador ou password incorretos!","Login Incorreto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void tbUtilizador_TextChanged(object sender, EventArgs e) {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e) {

        }
    }
}
