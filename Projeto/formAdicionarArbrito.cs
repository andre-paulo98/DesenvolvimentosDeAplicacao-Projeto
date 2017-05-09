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
        private ArbitroRepository arbitroRepos;
        private bool edit;
        private Referee arbitro;

        public formAdicionarArbrito(formUserReferee form, Modelo_Container dbContainer)
        {
            InitializeComponent();
            arbitroRepos = new ArbitroRepository(dbContainer);
            
        }
        public formAdicionarArbrito(formUserReferee form, Modelo_Container dbContainer, bool edicao, Referee arbitro)
        {
            InitializeComponent();
            arbitroRepos = new ArbitroRepository(dbContainer);
            this.edit = edicao;
            this.arbitro = arbitro;
            if (edit)  //Mudar labels para modo de edição
            {
                this.Text = "Editar Arbitro";
                btGuardar.Text = "Editar";
                tbNome.Text = arbitro.Name;
                tbUsername.Text = arbitro.Username;
                tbPassword.Text = arbitro.Password;
            }
        }


        private void btGuardar_Click(object sender, EventArgs e)//bt guardar
        {
            if (tbUsername.Text == "" || tbPassword.Text =="" || tbNome.Text == "") //verificação dos campos se estão validos
            {
                MessageBox.Show("Introduza todos os campos obrigatórios", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensagem de erro se na falta de dados
            }
            else
            {
                
                if (edit)
                {
                    arbitroRepos.EditReferee(arbitro);
                }
                else
                {
                    Referee NovoArbitro = new Referee();//objeto arbitro
                    NovoArbitro.Username = tbUsername.Text;//adicionar os valores ao arbitro
                    NovoArbitro.Password = tbPassword.Text;
                    NovoArbitro.Name = tbNome.Text;
                    NovoArbitro.Avatar = "";
                    arbitroRepos.AddReferee(NovoArbitro);
                }
                Close();
            }
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
