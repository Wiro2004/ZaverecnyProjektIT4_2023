using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT_Rossler
{
    internal class Hour
    {
        public Hour(int id, int hours, int idEmployee, int idContract, int idType, DateTime date)
        {
            Id = id;
            Hours = hours;
            IdEmployee = idEmployee;
            IdContract = idContract;
            IdType = idType;
            Date = date;
        }

        public int Id { get; set; }
        public int Hours { get; set; }
        public int IdEmployee { get; set; }
        public int IdContract { get; set; }
        public int IdType { get; set; }
        public DateTime Date { get; set; }
    }
}
