using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_MPP_CSharp.Domain;

namespace Proiect_MPP_CSharp.Repos
{
    interface RepositoryExcursie:IRepository<string, Excursie>
    {
        ICollection<Excursie> filtrare1(string obiectiv, string ora1, string ora2);
    }
}
