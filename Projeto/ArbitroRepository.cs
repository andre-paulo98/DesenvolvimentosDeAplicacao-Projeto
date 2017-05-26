using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    class ArbitroRepository
    {
        private Modelo_Container container;
        private List<Referee> listaArbitro;//Lista de arbitros

        public ArbitroRepository(Modelo_Container container)
        {
            this.container = container; //cria objeto do container
            listaArbitro = new List<Referee>();
        }

        public void AddReferee(Referee arbitro)
        {
            container.User.Add(arbitro);//Adicionar ao container o objeto arbitro
            listaArbitro.Add(arbitro);
            container.SaveChanges();
        }
        public List<Referee> GetRefereeList()
        {
            listaArbitro = container.User.OfType<Referee>().ToList(); //buscar uma lista de arbitros
            return listaArbitro;
        }
        public void DeleteReferee(Referee arbitro)
        {
            container.User.Remove(arbitro);
            container.SaveChanges();
        }
        public List<Referee> SearchArbitro(string nome)
        {
            return (from Referee in container.User.OfType<Referee>().ToList()
                    where Referee.Name.ToUpper().Contains(nome.ToUpper())
                    select Referee).ToList();
        }
        public void EditReferee()
        {
            container.SaveChanges();
        }

        public bool VerifyUsername(string Username1)
        {
            return ((from user in container.User
                       where user.Username.ToUpper() == Username1.ToUpper()
                       select user).ToList<User>().Count != 0); //se existir return true
        }
        public bool VerifyTorneio(Referee arbitro)
        {
            return ((from game in container.Game
                     where game.RefereeId == arbitro.Id
                     select game).ToList().Count != 0); //se existir return true
        }
    }
}
