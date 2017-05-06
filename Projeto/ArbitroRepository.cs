using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Referee GetReferee(int id)
        {
            Referee arbitro = (from Referee in container.User.OfType<Referee>().ToList()
                          where Referee.Id == id
                          select Referee).First();
            return arbitro;
        }
        public List<Referee> GetRefereeList()
        {
            listaArbitro = container.User.OfType<Referee>().ToList(); //buscar uma lista de arbitros
            return listaArbitro;
        }
        public void DeleteReferee(int arbitroId)//*
        {
            User arbitroAApagar = container.User.ToList().ElementAt(arbitroId);//vai buscar o arbitro por id*
            container.User.ToList().RemoveAt(arbitroId);
            container.User.Remove(arbitroAApagar);
            container.SaveChanges();
        }
        public List<Referee> SearchArbitro(string nome)
        {
            return (from Referee in container.User.OfType<Referee>().ToList()
                    where Referee.Name.ToUpper().Contains(nome.ToUpper())
                    select Referee).ToList();
        }
        public void EditReferee(Referee arbitro)
        {
            Referee arbitroLista = (from Referee in container.User.OfType<Referee>().ToList() //perguntar ao andré o que é que isto quer dizer
                                    where Referee.Id == arbitro.Id
                                    select Referee).First();
            arbitroLista = arbitro;
            Referee originArbitro = (from Referee in container.User.OfType<Referee>().ToList()//perguntar ao andré o que é que isto quer dizer
                                     where Referee.Id == arbitro.Id
                                     select Referee).First();
            originArbitro = arbitro;
            container.SaveChanges();
        }
    }
}
