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
    public partial class formAdicionarAdmin : Form
    {
        AdminRepository adminRepos;
        private bool edit = false;
        private Administrador adminParaEdicao;
        public formAdicionarAdmin(formUserAdmin form, Modelo_Container dbContainer)
        {
            InitializeComponent();
            adminRepos = new AdminRepository(dbContainer);
        }
        public formAdicionarAdmin(formUserAdmin form, Modelo_Container dbContainer, Administrador admin)
        {
            InitializeComponent();
            edit = true;
            adminRepos = new AdminRepository(dbContainer);
            this.adminParaEdicao = admin;
            if (edit)  //Mudar labels para modo de edição
            {
                this.Text = "Editar Administrador";
                btAdicionar.Text = "Editar";
                labelTitulo.Text = "Editar Administrador";
                tbUsername.Text = admin.Username;
                tbPassword.Text = admin.Password;
                tbEmail.Text = admin.email;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" || tbEmail.Text == "") //verificação dos campos se estão validos
            {
                MessageBox.Show("Introduza todos os campos obrigatórios", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensagem de erro se na falta de dados
            }
            else
            {

                if (edit)
                {
                    adminParaEdicao.Username = tbUsername.Text;
                    adminParaEdicao.Password = tbPassword.Text;
                    adminParaEdicao.email = tbEmail.Text;
                    adminRepos.EditAdmin(); //Editar.
                }
                else
                {
                    Administrador NovoAdmin = new Administrador();//objeto arbitro
                    NovoAdmin.Username = tbUsername.Text;//adicionar os valores ao arbitro
                    NovoAdmin.Password = tbPassword.Text;
                    NovoAdmin.email = tbEmail.Text;
                    adminRepos.AddAdmin(NovoAdmin);
                }
                Close();
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAdicionar.PerformClick();
            }
        }
    }
}
