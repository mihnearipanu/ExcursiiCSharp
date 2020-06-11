using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_MPP_CSharp.Repos;
using Proiect_MPP_CSharp.Domain;

namespace Proiect_MPP_CSharp.Services
{
    class ServBilet
    {
        private RepositoryBilet repositoryBilet;
        private RepositoryExcursie repositoryExcursie;

        public ServBilet(RepositoryBilet repoBilet, RepositoryExcursie repoExcursie) {
            this.repositoryBilet = repoBilet;
            this.repositoryExcursie = repoExcursie;
        }

        public void rezervare(Bilet bilet) {
            repositoryBilet.save(bilet);
            Excursie excursie = repositoryExcursie.findOne(bilet.idExcursie);
            excursie.nrLocuri -= bilet.nrLocuri;
            repositoryExcursie.update(excursie.id, excursie);
        }
    }
}
