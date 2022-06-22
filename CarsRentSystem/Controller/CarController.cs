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

namespace CarsRentSystem.Controller
{
    internal class CarController
    {
        string connection = ConfigurationManager.ConnectionStrings["RentSystem"].ConnectionString;

        //Get All Employees From the Database
        public List<CarModel> GetAll()
        {
            var Cars = new List<CarModel>();
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "Select * from Car order by ID";
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Car = new CarModel();
                            Car.ID = (int)reader[0];
                            Car.model = reader[1].ToString();
                            Car.registration = reader[2].ToString();
                            Car.dailyHirePrice = (int)reader[3];
                            Car.YOM = (int)reader[4];
                            Car.color = reader[5].ToString();
                            Car.capacity = (int)reader[6];
                            Car.fual = reader[7].ToString();
                            Car.transmission = reader[8].ToString();
                            Car.status = reader[9].ToString();

                            Cars.Add(Car);
                        }
                    }
                    dbConnection.Close();
                }
            }
            return Cars;
        }

        //Add new Employee to the Database
        public void Add(CarModel Car)
        {
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"insert into Car (model, registration, dailyHirePrice, YOM,
					                                                color, capacity, fual, transmission, status)
		                                                values (@model, @registration, @dailyHirePrice, @YOM,
					                                                @color, @capacity, @fual, @transmission, @status)";

                    dbCommand.Parameters.Add("@model", SqlDbType.VarChar).Value = Car.model;
                    dbCommand.Parameters.Add("@registration", SqlDbType.VarChar).Value = Car.registration;
                    dbCommand.Parameters.Add("@dailyHirePrice", SqlDbType.VarChar).Value = Convert.ToInt32(Car.dailyHirePrice);
                    dbCommand.Parameters.Add("@YOM", SqlDbType.VarChar).Value = Convert.ToInt32(Car.YOM);
                    dbCommand.Parameters.Add("@color", SqlDbType.VarChar).Value = Car.color;
                    dbCommand.Parameters.Add("@capacity", SqlDbType.VarChar).Value = Convert.ToInt32(Car.capacity);
                    dbCommand.Parameters.Add("@fual", SqlDbType.VarChar).Value = Car.fual;
                    dbCommand.Parameters.Add("@transmission", SqlDbType.VarChar).Value = Car.transmission;
                    dbCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = Car.status;

                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
        }

        //Update Employee info
        public void Update(CarModel Car, int ID)
        {
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"update Car SET
		                                        model = @model,
		                                        registration = @registration,
		                                        dailyHirePrice = @dailyHirePrice,
		                                        YOM = @YOM,
		                                        color = @color,
		                                        capacity = @capacity,
		                                        fual = @fual,
		                                        transmission = @transmission,
		                                        status = @status
		                                            WHERE ID = @ID";

                    dbCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = Convert.ToInt32(ID);

                    dbCommand.Parameters.Add("@model", SqlDbType.VarChar).Value = Car.model;
                    dbCommand.Parameters.Add("@registration", SqlDbType.VarChar).Value = Car.registration;
                    dbCommand.Parameters.Add("@dailyHirePrice", SqlDbType.VarChar).Value = Convert.ToInt32(Car.dailyHirePrice);
                    dbCommand.Parameters.Add("@YOM", SqlDbType.VarChar).Value = Convert.ToInt32(Car.YOM);
                    dbCommand.Parameters.Add("@color", SqlDbType.VarChar).Value = Car.color;
                    dbCommand.Parameters.Add("@capacity", SqlDbType.VarChar).Value = Convert.ToInt32(Car.capacity);
                    dbCommand.Parameters.Add("@fual", SqlDbType.VarChar).Value = Car.fual;
                    dbCommand.Parameters.Add("@transmission", SqlDbType.VarChar).Value = Car.transmission;
                    dbCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = "Avaliable";

                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
        }

        public void InUse(bool inUse, int ID)
        {
            string use;
            if (inUse)
            {
                use = "In Use";
            }
            else
            {
                use = "Avaliable";
            }
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"update Car SET
		                                        status = @status
		                                            WHERE ID = @ID;";

                    dbCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = Convert.ToInt32(ID);

                    dbCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = use;

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
                    dbCommand.CommandText = @"delete from Car where ID = @ID";

                    dbCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = Convert.ToInt32(ID);

                    dbCommand.ExecuteNonQuery();
                }
            }
        }

        //Search Employees From the Database by name
        public List<CarModel> Search(string search)
        {
            var Cars = new List<CarModel>();
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "Select * from Car where model like '%" + search + "%';";
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Car = new CarModel();
                            Car.ID = (int)reader[0];
                            Car.model = reader[1].ToString();
                            Car.registration = reader[2].ToString();
                            Car.dailyHirePrice = (int)reader[3];
                            Car.YOM = (int)reader[4];
                            Car.color = reader[5].ToString();
                            Car.capacity = (int)reader[6];
                            Car.fual = reader[7].ToString();
                            Car.transmission = reader[8].ToString();
                            Car.status = reader[9].ToString();

                            Cars.Add(Car);
                        }
                    }
                    dbConnection.Close();
                }
            }
            return Cars;
        }

        public int TotalCarUsed()
        {
            int count= 0;
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"Select count(ID) from Car where status = 'In Use'";
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

        public int TotalCarAvaliable()
        {
            int count = 0;
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"Select count(ID) from Car where status = 'Avaliable'";
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
