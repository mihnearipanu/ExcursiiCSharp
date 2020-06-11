using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_MPP_CSharp.Domain
{
    public class Bilet:Entity<string>
    {
        public string idExcursie { get; set; }
        public string client { get; set; }
        public int nrTelefon { get; set; }
        public int nrLocuri { get; set; }

        public Bilet(string id, string idExcursie, string client, int nrTelefon, int nrLocuri) : base(id) {
            this.idExcursie = idExcursie;
            this.client = client;
            this.nrTelefon = nrTelefon;
            this.nrLocuri = nrLocuri;
        }
    }
}
