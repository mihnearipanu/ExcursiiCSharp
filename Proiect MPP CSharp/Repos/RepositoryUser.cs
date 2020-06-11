using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_MPP_CSharp.Domain;

namespace Proiect_MPP_CSharp.Repos
{
    interface RepositoryUser: IRepository<string, User>
    {
        User findByUserAndPass(string username, string password);
    }
}
