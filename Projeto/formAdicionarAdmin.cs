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
                if (edit)//se for o modo de edição
                {   //Se o Username ou email que vinha da edição for alterado na tb *1*
                    if (adminParaEdicao.Username.Equals(tbUsername.Text, StringComparison.OrdinalIgnoreCase) || adminParaEdicao.email.Equals(tbEmail.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        if (adminRepos.VerifyUsername(tbUsername.Text))//Verifica se existe algum username e igual na db *2*
                        {
                            MessageBox.Show("Username já existente!", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensagem de duplicação
                        }
                        else if (adminRepos.VerifyEmail(tbEmail.Text))//Verifica se existe algum email e igual na db *2*
                        {
                            MessageBox.Show("Este E-mail já está associado a uma conta!", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensagem de duplicação
                        }
                        else //se for diferente *2*
                        {
                            adminParaEdicao.Username = tbUsername.Text;
                            adminParaEdicao.Password = tbPassword.Text;
                            adminParaEdicao.email = tbEmail.Text;
                            adminRepos.EditAdmin(); //Editar. 
                        }
                    }
                    else //Se a o que vinha para ser editado for igual ao que está na tb *1*
                    {
                        adminParaEdicao.Password = tbPassword.Text;
                        adminRepos.EditAdmin(); //Editar. 
                    }
                    Close();
                }
                else//se for o modo de adicionar
                {
                    Administrador novoAdmin = new Administrador();//Objeto admin
                    if (adminRepos.VerifyUsername(tbUsername.Text))
                    {   //Mensagem de duplicação de dados
                        MessageBox.Show("Username já existente!", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (adminRepos.VerifyEmail(tbEmail.Text))
                    {   //Mensagem de duplicação de dados
                        MessageBox.Show("Este E-mail já está associado a uma conta!", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensagem de duplicação
                    }
                    else
                    {//adicionar os valores ao arbitro
                        novoAdmin.Username = tbUsername.Text;
                        novoAdmin.Password = tbPassword.Text;
                        novoAdmin.email = tbEmail.Text;
                        adminRepos.AddAdmin(novoAdmin);
                        Close();
                    }
                }
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
