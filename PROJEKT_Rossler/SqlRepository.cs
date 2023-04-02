using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_Rossler
{
    internal class SqlRepository
    {
        public string connection;
        private string v;

        public SqlRepository()
        {
            connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employees;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public SqlRepository(string v)
        {
            this.v = v;
        }

        public void AddUser(int IdUser, int IdEmployee, string UserName, int Role, byte[] Password)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Users values (@IdUser,@idEmployee,@UserName,@Password,@IsAdmin)";
                    cmd.Parameters.AddWithValue("IdUser", IdUser);
                    cmd.Parameters.AddWithValue("idEmployee", IdEmployee);
                    cmd.Parameters.AddWithValue("UserName", UserName);
                    cmd.Parameters.AddWithValue("Role", Role);
                    cmd.Parameters.AddWithValue("Password", Password);


                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }


        }
        public void DeleteEmployee(int idEmployee)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Employees where IdEmployee=@idEmployee";
                    cmd.Parameters.AddWithValue("IdEmployee", idEmployee);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void DeleteHours(int idHour)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Hours where IdHour=@idHour";
                    cmd.Parameters.AddWithValue("IdHour", idHour);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public Contract GetContract(int idContract)
        {
            Contract contract = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Contracts where IdContract=@idContract";
                    cmd.Parameters.AddWithValue("idContract", idContract);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contract = new Contract(Convert.ToInt32(reader["IdContract"]), reader["Name"].ToString(), reader["Popis"].ToString());
                        }
                    }
                }
                conn.Close();
            }
            return contract;
        }

        public void AddEmployee(string firstName, string lastName, DateTime birthDate, string email, string phone)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Employees values (@FirstName,@LastName,@BirthDate,@Email, @Phone)";
                    cmd.Parameters.AddWithValue("FirstName", firstName);
                    cmd.Parameters.AddWithValue("LastName", lastName);
                    cmd.Parameters.AddWithValue("BirthDate", birthDate);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("Phone", phone);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public Role GetRole(int idRole)
        {
            Role role = null;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Role where IdRole = @idRole";
            cmd.Parameters.AddWithValue("idRole", idRole);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                role = new Role(reader["Name"].ToString(), 0);
            }
            conn.Close();

            return role;
        }
        public List<Contract> GetContracts()
        {
            List<Contract> contracts = new List<Contract>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Contracts";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            contracts.Add(new Contract(Convert.ToInt32(reader["Id"]), reader["Name"].ToString(), reader["Popis"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return contracts;
        }
        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Role";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(new Role(reader["Name"].ToString(), Convert.ToInt32(reader["IdRole"])));
                        }
                    }
                }
                conn.Close();
            }
            return roles;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User(Convert.ToInt32(reader["IdUser"]), reader["UserName"].ToString(), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["Role"])));
                        }
                    }
                }
                conn.Close();
            }
            return users;
        }

        public User GetUser(int id)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where IdUser=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(reader["UserName"].ToString(), Convert.ToInt32(reader["IdUser"]), (byte[])reader["Password"], Convert.ToInt32(reader["Role"]));
                        }
                        else
                        {
                            MessageBox.Show("Uživatel neexistuje");
                        }
                    }
                }
                conn.Close();
            }
            return user;
        }
        public bool IsUsered(int id)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where IdEmployee=@idEmployee";
                    cmd.Parameters.AddWithValue("idEmployee", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(Convert.ToString(reader["IdUser"]));
                        }
                    }
                }
                conn.Close();
            }
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List <Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from employees";
                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee((int)reader["IdEmployee"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["BirthDate"], (string)reader["Email"], (string)reader["Phone"]));

                        }
                    }
                    
                }

                conn.Close();
                
                                                            
            }
            return employees;

        }
        public Employee GetEmployee(int idEmployee)
        {
            Employee employee = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Employees where IdEmployee=@id";
                    cmd.Parameters.AddWithValue("id", idEmployee);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee((int)reader["IdEmployee"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["BirthDate"], (string)reader["Email"], (string)reader["Phone"]); 
                        }
                        else
                        {
                            MessageBox.Show("Zaměstnanec neexistujew");
                        }
                    }
                }
                conn.Close();
            }
            return employee;
        }
        public Jobs GetJobs(int idJobs)
        {
            Jobs jobs = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())

                {
                    cmd.CommandText = "select * from Jobs where IdJobs=@idJobs";
                    cmd.Parameters.AddWithValue("idJobs", idJobs);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            jobs = new Jobs(Convert.ToInt32(reader["IdJobs"]), reader["Popis"].ToString());
                        }
                    }
                }
                conn.Close();
            }
            return jobs;
        }
        public List<Hour> GetHours()
        {
            List<Hour> hours = new List<Hour>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Hours";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hours.Add(new Hour(Convert.ToInt32(reader["IdHours"]), Convert.ToInt32(reader["Name"], Convert.ToInt32(reader["Hours"]))));
                        }
                    }
                }
                conn.Close();
            }
            return hours;
        }

        public void AddJobs(string popis)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Jobs values (@Popis)";
                    cmd.Parameters.AddWithValue("popis", popis);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void DeleteUser(int idUser)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Users where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void DeleteJobs(int idJobs)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Jobs where IdJobs=@idJobs";
                    cmd.Parameters.AddWithValue("idJobs", idJobs);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void DeleteContract(int idContract)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Contracts where IdContract=@idContract";
                    cmd.Parameters.AddWithValue("idContract", idContract);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }


        public void DeleteRole(int idRole)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Roles where IdRole=@idRole";
                    cmd.Parameters.AddWithValue("idRole", idRole);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        internal void AddUser(int v, string userName, byte[] password, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        internal User GetUser(string text)
        {
            throw new NotImplementedException();
        }
    }
}
