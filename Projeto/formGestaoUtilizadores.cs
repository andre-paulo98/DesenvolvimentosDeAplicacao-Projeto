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
    public partial class formGestaoUtilizadores : Form {

        private string username;
        private string password;
        private string nome;
        private string email;

        Modelo_Container container;//cria objeto do container

        public formGestaoUtilizadores(Modelo_Container dbContainer)
        {
            InitializeComponent();
            container = dbContainer;
            labelNome.Hide();
            tbNome.Hide();
        }

        private void inserirUser(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Insira o Username!","Dados inválidos",MessageBoxButtons.OK,MessageBoxIcon.Warning); //Mensagem de erro se na falta de dados
            }
            else{ username = tbUsername.Text; }

           password = tbPassword.Text;
           nome = tbNome.Text;
           email = tbNome.Text;
            
            Administrador admin = new Administrador();  //cria objeto admin
            Referee arbrito = new Referee();  //cria objeto arbrito

            if (cbCargo.SelectedIndex == 0) //inserir dados caso seja selecionado admin
            {
                admin.Username = username;
                admin.Password = password;
                admin.email = email;
            }
            else if (cbCargo.SelectedIndex == 1) // inserir dados caso seja selecionado arbrito
            {
                arbrito.Username = username;
                arbrito.Password = password;
                arbrito.Name = nome;
            }

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCargo.SelectedIndex == 0) //muda o nome da label para email quando a combo-box muda para admin
            {
                labelNome.Text = "E-mail";
            }
            else if (cbCargo.SelectedIndex == 1)//muda o nome da label para email quando a combo-box muda para arbrito
            {
                labelNome.Text = "Nome";
            }
            labelNome.Show();
            tbNome.Show();
        }
    }
}
