using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class AdminRepository
    {
        private Modelo_Container container;
        private List<Administrador> listaAdmin;//Lista de admins

        public AdminRepository(Modelo_Container container)
        {
            this.container = container; //cria objeto do container
            listaAdmin = new List<Administrador>();
        }

        public void AddAdmin(Administrador admin)
        {
            container.User.Add(admin);//Adicionar ao container o objeto admin
            listaAdmin.Add(admin);
            container.SaveChanges();
        }

        public Administrador GetAdmin(int id)
        {
            Administrador admin = (from Administrador in container.User.OfType<Administrador>().ToList()
                               where Administrador.Id == id
                               select Administrador).First();
            return admin;
        }
        public List<Administrador> GetAdmin()
        {
            listaAdmin = container.User.OfType<Administrador>().ToList(); //buscar uma lista de admins
            return listaAdmin;
        }
        public void DeleteAdmi(int adminId)//*
        {
            
        }
        public List<Administrador> SearchAdmin(string username)
        {
            return (from Administrador in container.User.OfType<Administrador>().ToList()
                    where Administrador.Username.ToUpper().Contains(username.ToUpper())
                    select Administrador).ToList();
        }
        public void EditReferee(Referee arbitro)
        {
            
        }
    }
}
