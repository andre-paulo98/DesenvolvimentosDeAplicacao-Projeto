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

        private bool edit = false;
        public formAdicionarAdmin(formUserAdmin form, Modelo_Container dbContainer)
        {
            InitializeComponent();
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
                    //arbitroRepos.EditReferee(arbitro);
                }
                else
                {
                    Administrador NovoAdmin = new Administrador();//objeto arbitro
                    NovoAdmin.Username = tbUsername.Text;//adicionar os valores ao arbitro
                    NovoAdmin.Password = tbPassword.Text;
                    NovoAdmin.email = tbEmail.Text;
                    //NovoAdmin.AddReferee(NovoArbitro);
                }
                Close();
            }
        }
    }
}
