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
    public partial class formUserAdmin : Form
    {
        private Modelo_Container dbContainer;
        private List<Administrador> adminList;
        private AdminRepository adminRepos;
        private Administrador currentAdmin;
        public formUserAdmin(Modelo_Container container)
        {
            InitializeComponent();
            this.dbContainer = container;
            adminRepos = new AdminRepository(dbContainer);
            RefreshView();
        }

        private void btAddNovo_Click(object sender, EventArgs e)
        {
            formAdicionarAdmin addAdmin = new formAdicionarAdmin(this, dbContainer);
            addAdmin.FormClosing += new FormClosingEventHandler(formUserAdmin_FormClosing); // *1*
            addAdmin.ShowDialog(this);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (lbAdmin.SelectedIndex != -1)
            {
                adminRepos.DeleteAdmin(adminList.ElementAt(lbAdmin.SelectedIndex));//remover Admin com o metodo DeleteAdmin no AdminRepository
                RefreshView();
            }
        }
        private void RefreshView() // método para refresh da lista de admins
        {
            adminList = adminRepos.GetAdminList();
            lbAdmin.Items.Clear();
            btEditar.Hide();
            foreach (Administrador Admin in adminList)
            {
                lbAdmin.Items.Add(Admin.Id + " - " + Admin.Username);//Lista de admins
            }
        }

        private void formUserAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshView();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            currentAdmin = adminList.ElementAt(lbAdmin.SelectedIndex);
            formAdicionarAdmin aditAdmin = new formAdicionarAdmin(this, dbContainer, currentAdmin);//editar a true muda o form de forma
            aditAdmin.FormClosing += new FormClosingEventHandler(formUserAdmin_FormClosing);
            aditAdmin.ShowDialog(this);
        }

        private void lbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAdmin.SelectedIndex != -1)
            {
                btEditar.Show(); //Aparecer o botão de editar quando é selecionado algum nome
            }
        }
    }
}
