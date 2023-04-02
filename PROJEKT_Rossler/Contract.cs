using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT_Rossler
{
    internal class Contract
    {
        public Contract(int id, string name, string popis)
        {
            Id = id;
            Name = name;
            Popis = popis;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Popis { get; set; }
    }
}