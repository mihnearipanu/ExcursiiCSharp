using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_MPP_CSharp.Repos;
using Proiect_MPP_CSharp.Domain;

namespace Proiect_MPP_CSharp.Services
{
    class ServExcursie
    {
        private RepositoryExcursie repo;

        public ServExcursie(RepositoryExcursie repo) {
            this.repo = repo;
        }

        public Excursie findOne(string id) {
            return repo.findOne(id);
        }

        public ICollection<Excursie> getAll() {
            return repo.findAll();
        }

        public ICollection<Excursie> getFiltrare(string obiectiv, string ora1, string ora2)
        {
            return repo.filtrare1(obiectiv, ora1, ora2);
        }
    }
}
