using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

using CarsRentSystem.Models;
using CarsRentSystem.Controller;

using System.Configuration;
using System.Data.SqlClient;


using System.Windows.Forms; // For debuging

namespace CarsRentSystem.Controller
{
    class EmployeeController
    {
        string connection = ConfigurationManager.ConnectionStrings["RentSystem"].ConnectionString;

        //Get All Employees From the Database
        public List<EmployeeModel> GetAll()
        {
            var Employees = new List<EmployeeModel>();
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "Select * from Employee order by ID";
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Employee = new EmployeeModel();
                            Employee.ID = (int)reader[0];
                            Employee.fullName = reader[1].ToString();
                            Employee.email = reader[2].ToString();
                            Employee.password = reader[3].ToString();
                            Employee.role = reader[4].ToString();
                            Employee.phoneNumber = (int)reader[5];
                            Employee.salary = (int)reader[6];
                            Employees.Add(Employee);
                        }
                    }
                    dbConnection.Close();
                }
            }
            return Employees;
        }
        
        //Add new Employee to the Database
        public void Add(EmployeeModel Employee)
        {
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"insert into Employee (fullName, email, password, role, phoneNumber, salary)
		                                                    values (@fullName, @email, @password, @role, @phoneNumber, @salary);";

                    dbCommand.Parameters.Add("@fullName", SqlDbType.VarChar).Value = Employee.fullName;
                    dbCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = Employee.email;
                    dbCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = Employee.password;
                    dbCommand.Parameters.Add("@role", SqlDbType.VarChar).Value = Employee.role;
                    dbCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = Convert.ToInt32(Employee.phoneNumber);
                    dbCommand.Parameters.Add("@salary", SqlDbType.VarChar).Value = Convert.ToInt32(Employee.salary);

                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
        }

        //Update Employee info
        public void Update(EmployeeModel Employee, int ID)
        {
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"update Employee SET
		                                        fullName = @fullName, 
		                                        email = @email,
		                                        password = @password,
		                                        role = @role,
		                                        phoneNumber = @phoneNumber,
		                                        salary = @salary
			                                        where ID = @ID";

                    dbCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = Convert.ToInt32(ID);

                    dbCommand.Parameters.Add("@fullName", SqlDbType.VarChar).Value = Employee.fullName;
                    dbCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = Employee.email;
                    dbCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = Employee.password;
                    dbCommand.Parameters.Add("@role", SqlDbType.VarChar).Value = Employee.role;
                    dbCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = Convert.ToInt32(Employee.phoneNumber);
                    dbCommand.Parameters.Add("@salary", SqlDbType.VarChar).Value = Convert.ToInt32(Employee.salary);

                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
        }

        //Delete Employee from the databse
        public void Delete(int ID)
        {
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"delete from Employee where ID = @ID;";

                    dbCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = Convert.ToInt32(ID);

                    dbCommand.ExecuteNonQuery();
                }
            }
        }

        //Search Employees From the Database by name
        public List<EmployeeModel> Search(string search)
        {
            var Employees = new List<EmployeeModel>();
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "Select * from Employee where fullName like '%" + search + "%';";
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Employee = new EmployeeModel();
                            Employee.ID = (int)reader[0];
                            Employee.fullName = reader[1].ToString();
                            Employee.email = reader[2].ToString();
                            Employee.password = reader[3].ToString();
                            Employee.role = reader[4].ToString();
                            Employee.phoneNumber = (int)reader[5];
                            Employee.salary = (int)reader[6];
                            Employees.Add(Employee);
                        }
                    }
                    dbConnection.Close();
                }
            }
            return Employees;
        }

        public string[] Login(string emplyEmail, string emplyPassword)
        {
            string[] account;
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;

                    dbCommand.CommandText = "Select * from Employee where email = @email and password = @password";

                    dbCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = emplyEmail;
                    dbCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = emplyPassword;

                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (emplyEmail == reader[2].ToString() && emplyPassword == reader[3].ToString())
                            {
                                account = new string[3] { "True", reader[0].ToString(), reader[1].ToString() };
                                return account;
                            }
                            else
                            {
                                account = new string[2] { "False", "No User" };
                                return account;
                            }
                        }
                        else
                        {
                            account = new string[2] { "False", "No User" };
                            return account;
                        }
                    }
                }
            }

        }
    }
}