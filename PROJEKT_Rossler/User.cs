using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT_Rossler
{
    public class User
    {
        public string UserName { get; set; }
        public int Role { get; set; }
        public byte[] Password { get; set; }
        public int IdEmployee { get; set; }
        public int Id { get; set; }

        public User(string userName, int id, byte[] password, int role)
        {
            UserName = userName;
            Password = password;
            Id = id;
            Role = role;
        }

        public User(int id, string userName, int idEmployee, int role)
        {
            IdEmployee = idEmployee;
            UserName = userName;
            Id = id;
            Role = role;
        }

        public User(int id)
        {
            Id = id;
        }

        public User(string userName)
        {
            UserName = userName;
        }

    
    }
}
