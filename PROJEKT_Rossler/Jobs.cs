using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT_Rossler
{
    internal class Jobs
    {
        private string v;

        public Jobs(int id, string Popis)
        {
            Id = id;
            Popis = popis;
        }

        public Jobs(int id, string Popis, string v) : this(id, Popis)
        {
            this.v = v;
        }

        public int Id { get; set; }
        public string popis { get; set; }
    }
}
