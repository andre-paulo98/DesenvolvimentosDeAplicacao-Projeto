using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto
{
    public partial class formAdicionarArbrito : Form
    {
        private ArbitroRepository arbitroRepos;
        private Referee arbitroParaEdicao;
        bool edit = false;
        Image image;
        public formAdicionarArbrito(formUserReferee form,Modelo_Container dbContainer)
        {
            InitializeComponent();
            arbitroRepos = new ArbitroRepository(dbContainer);
            image = (Image)pbAvatar.BackgroundImage.Clone();
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
                labelTitulo.Text = "Editar Arbitro";
                tbNome.Text = arbitro.Name;
                tbUsername.Text = arbitro.Username;
                tbPassword.Text = arbitro.Password;
                pbAvatar.ImageLocation = arbitro.Avatar;
                image = (Image)pbAvatar.BackgroundImage.Clone();
                if (arbitro.Avatar != "")
                {
                    pbAvatar.BackgroundImage = null;
                }
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
                if (edit)//se for o modo de edição
                {
                    if (!arbitroParaEdicao.Username.Equals(tbUsername.Text, StringComparison.OrdinalIgnoreCase))//Se o Username que vinha da edição for alterado na tb *1*
                    {
                        if (arbitroRepos.VerifyUsername(tbUsername.Text))//Verifica se existe algum igual na db *2*
                        {
                            MessageBox.Show("Username já existente!", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensagem de duplicação
                        }
                        else //se for diferente *2*
                        {
                            arbitroParaEdicao.Name = tbNome.Text;
                            arbitroParaEdicao.Username = tbUsername.Text;
                            arbitroParaEdicao.Password = tbPassword.Text;
                            arbitroParaEdicao.Avatar = pbAvatar.ImageLocation;
                            arbitroRepos.EditReferee(); //Editar
                        }
                    }
                    else //Se a o que vinha para ser editado for igual ao que está na tb *1*
                    {
                        arbitroParaEdicao.Name = tbNome.Text;
                        arbitroParaEdicao.Password = tbPassword.Text;
                        arbitroParaEdicao.Avatar = pbAvatar.ImageLocation;
                        arbitroRepos.EditReferee(); //Editar.
                    }
                    Close();
                }
                else//se for o modo de adicionar
                {
                    Referee NovoArbitro = new Referee();//objeto arbitro
                    if (arbitroRepos.VerifyUsername(tbUsername.Text))
                    {   //Mensagem de duplicação de dados
                        MessageBox.Show("Username já existente!", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    }
                    else
                    {//adicionar os valores ao arbitro
                        NovoArbitro.Username = tbUsername.Text;
                        NovoArbitro.Password = tbPassword.Text;
                        NovoArbitro.Name = tbNome.Text;
                        if (pbAvatar.ImageLocation != null)
                        {
                            NovoArbitro.Avatar = pbAvatar.ImageLocation;
                        }
                        
                        else
                        {
                            NovoArbitro.Avatar = "";
                        }
                        arbitroRepos.AddReferee(NovoArbitro);
                        Close();
                    }
                }
            }
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void KeyDown_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//guardar ao carregar no enter
                btGuardar.PerformClick();
            }
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                pbAvatar.Load(openFileDialog.FileName);
                pbAvatar.BackgroundImage = null;
            }
        }

        private void btErase_Click(object sender, EventArgs e)
        {
            pbAvatar.Image = null;
            pbAvatar.BackgroundImage = image;
            pbAvatar.ImageLocation = "";
        }
    }
}
