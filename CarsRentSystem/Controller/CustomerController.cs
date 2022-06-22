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
    class CustomerController
    {
        string connection = ConfigurationManager.ConnectionStrings["RentSystem"].ConnectionString;

        //Get All Employees From the Database
        public List<CustomerModel> GetAll()
        {
            var Customers = new List<CustomerModel>();
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "Select * from Customer order by ID";
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Customer = new CustomerModel();
                            Customer.ID = (int)reader[0];
                            Customer.fullName = reader[1].ToString();
                            Customer.email = reader[2].ToString();
                            Customer.phoneNumber = (int)reader[3];
                            Customer.gender = reader[4].ToString();

                            Customers.Add(Customer);
                        }
                    }
                    dbConnection.Close();
                }
            }
            return Customers;
        }

        //Add new Employee to the Database
        public void Add(CustomerModel Customer)
        {
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"insert into Customer (fullName, email, phoneNumber, Gender)
		                                        values (@fullName, @email, @phoneNumber, @Gender);";

                    dbCommand.Parameters.Add("@fullName", SqlDbType.VarChar).Value = Customer.fullName;
                    dbCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = Customer.email;
                    dbCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = Convert.ToInt32(Customer.phoneNumber);
                    dbCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Customer.gender;

                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
        }

        //Update Employee info
        public void Update(CustomerModel Customer, int ID)
        {
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"update Customer SET
		                                        fullName = @fullName,
		                                        email = @email,
		                                        phoneNumber = @phoneNumber,
		                                        Gender = @Gender
		                                            WHERE ID = @ID";

                    dbCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = Convert.ToInt32(ID);

                    dbCommand.Parameters.Add("@fullName", SqlDbType.VarChar).Value = Customer.fullName;
                    dbCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = Customer.email;
                    dbCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = Convert.ToInt32(Customer.phoneNumber);
                    dbCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Customer.gender;

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
                    dbCommand.CommandText = @"delete from Customer where ID = @ID";

                    dbCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = Convert.ToInt32(ID);

                    dbCommand.ExecuteNonQuery();
                }
            }
        }

        //Search Employees From the Database by name
        public List<CustomerModel> Search(string search)
        {
            var Customers = new List<CustomerModel>();
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "Select * from Customer where fullName like '%" + search + "%';";
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Customer = new CustomerModel();
                            Customer.ID = (int)reader[0];
                            Customer.fullName = reader[1].ToString();
                            Customer.email = reader[2].ToString();
                            Customer.phoneNumber = (int)reader[3];
                            Customer.gender = reader[4].ToString();

                            Customers.Add(Customer);
                        }
                    }
                    dbConnection.Close();
                }
            }
            return Customers;
        }

        public int TotalCustomer()
        {
            int count = 0;
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"Select count(ID) from Customer";
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count = (int)reader[0];
                        }
                    }
                    dbConnection.Close();
                }
            }
            return count;
        }
    }
}
