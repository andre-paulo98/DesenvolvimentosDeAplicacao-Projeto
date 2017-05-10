using System;
using System.Windows.Forms;

namespace Projeto
{
    public partial class formAdicionarArbrito : Form
    {
        private ArbitroRepository arbitroRepos;
        private Referee arbitroParaEdicao;
        bool edit = false;
        public formAdicionarArbrito(formUserReferee form,Modelo_Container dbContainer)
        {
            InitializeComponent();
            arbitroRepos = new ArbitroRepository(dbContainer);
            
        }
        public formAdicionarArbrito(formUserReferee form, Modelo_Container dbContainer, Referee arbitro)
        {
            InitializeComponent();
            edit = true;
            arbitroRepos = new ArbitroRepository(dbContainer);
            this.arbitroParaEdicao = arbitro;
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
            if (tbUsername.Text == "" || tbPassword.Text == "" || tbNome.Text == "") //verificação dos campos se estão validos
            {
                MessageBox.Show("Introduza todos os campos obrigatórios", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensagem de erro se na falta de dados
            }
           
            else
            {

                if (edit)
                {
                    arbitroParaEdicao.Name = tbNome.Text;
                    arbitroParaEdicao.Username = tbUsername.Text;
                    arbitroParaEdicao.Password = tbPassword.Text;
                    arbitroRepos.EditReferee(); //Editar.
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
