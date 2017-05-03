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
    public partial class formAdicionarArbrito : Form
    {
        public formUserReferee formUserRefere; // *1
        private ArbitroRepository arbitroRepos;

        public formAdicionarArbrito(formUserReferee form, Modelo_Container dbContainer)
        {
            InitializeComponent();
            formUserRefere = form; // *1 Instância anterior aqui
            arbitroRepos = new ArbitroRepository(dbContainer);
        }

        private void formAdicionarArbrito_FormClosed(object sender, FormClosedEventArgs e)
        {
            formUserRefere.Show();
        }

        private void btGuardar_Click(object sender, EventArgs e)//bt guardar
        {
            if (tbUsername.Text == "" || tbPassword.Text =="" || tbNome.Text == "") //verificação dos campos se estão validos
            {
                MessageBox.Show("Introduza todos os campos obrigatórios", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensagem de erro se na falta de dados
            }
            else
            {
                Referee arbitro = new Referee();//objeto arbitro
                

                arbitro.Username = tbUsername.Text;//adicionar os valores ao arbitro
                arbitro.Password = tbPassword.Text;
                arbitro.Name = tbNome.Text;
                arbitro.Avatar = "";

                arbitroRepos.AddReferee(arbitro);
                Close();
            } 
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
