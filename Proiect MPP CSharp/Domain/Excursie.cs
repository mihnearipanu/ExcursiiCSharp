using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_MPP_CSharp.Domain
{
    public class Excursie:Entity<string>
    {
        public string numeCompTrans { get; set; }
        public string obiectiv { get; set; }
        public string oraPlecarii { get; set; }
        public double pret { get; set; }
        public int nrLocuri { get; set; }

        public Excursie(string id, string numeCompTrans, string obiectiv, string oraPlecarii, double pret, int nrLocuri) : base(id) {
            this.numeCompTrans = numeCompTrans;
            this.obiectiv = obiectiv;
            this.oraPlecarii = oraPlecarii;
            this.pret = pret;
            this.nrLocuri = nrLocuri;
        }
    }
}
