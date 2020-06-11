using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_MPP_CSharp.Domain
{
    public class User:Entity<string>
    {
        string username { get; set; }
        string password { get; set; }

        public User(string id, string username, string password):base(id)
        {
            this.username = username;
            this.password = password;
        }
    }
}
