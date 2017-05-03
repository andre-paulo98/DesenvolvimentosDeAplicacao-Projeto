using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto {
    class UserRepository {
        private Modelo_Container dbConteirner;

        public UserRepository(Modelo_Container dbConteirner) {
            this.dbConteirner = dbConteirner;
        }

        public List<User> UserList() {
            List<User> UsersList = dbConteirner.User.ToList<User>();
            return UsersList;
        }
    }
}
