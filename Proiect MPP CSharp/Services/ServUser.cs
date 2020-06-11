using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_MPP_CSharp.Domain;
using Proiect_MPP_CSharp.Repos;

namespace Proiect_MPP_CSharp.Services
{
    class ServUser
    {
        private RepositoryUser repo;

        public ServUser(RepositoryUser repo) {
            this.repo = repo;
        }

        public bool verifica(string username, string password) {
            User user = repo.findByUserAndPass(username, password);
            return user != null;
        }
    }
}
