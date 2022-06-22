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
    internal class RentController
    {
        string connection = ConfigurationManager.ConnectionStrings["RentSystem"].ConnectionString;

        //Get All Employees From the Database
        public List<RentModel> GetAll()
        {
            var Rents = new List<RentModel>();
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "Select * from Rent order by ID";
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Rent = new RentModel();
                            Rent.ID = (int)reader[0];
                            Rent.customerID = (int)reader[1];
                            Rent.carID = (int)reader[2];
                            Rent.EmployeeID = (int)reader[3];
                            Rent.startDate = (DateTime)reader[4];
                            Rent.endDate = (DateTime)reader[5];
                            Rent.rentCost = (int)reader[6];
                            Rent.status = reader[7].ToString();

                            Rents.Add(Rent);
                        }
                    }
                    dbConnection.Close();
                }
            }
            return Rents;
        }

        //Add new Employee to the Database
        public void Add(RentModel Rent)
        {
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"insert into Rent (customerID, carID, EmployeeID, startDate, endDate, rentCost, status)
		                                    values (@customerID, @carID, @EmployeeID, @startDate, @endDate, @rentCost, @status)";

                    dbCommand.Parameters.Add("@customerID", SqlDbType.VarChar).Value = Convert.ToInt32(Rent.customerID); 
                    dbCommand.Parameters.Add("@carID", SqlDbType.VarChar).Value = Convert.ToInt32(Rent.carID); 
                    dbCommand.Parameters.Add("@EmployeeID", SqlDbType.VarChar).Value = Convert.ToInt32(Rent.EmployeeID);
                    dbCommand.Parameters.Add("@startDate", SqlDbType.VarChar).Value = (DateTime)Rent.startDate;
                    dbCommand.Parameters.Add("@endDate", SqlDbType.VarChar).Value = (DateTime)Rent.endDate;
                    dbCommand.Parameters.Add("@rentCost", SqlDbType.VarChar).Value = Convert.ToInt32(Rent.rentCost);
                    dbCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = "In Use";


                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
        }

        //Update Employee info
        public void Return(int ID)
        {
            using (var dbConnection = new SqlConnection(connection))
            {
                using (var dbCommand = new SqlCommand())
                {
                    dbConnection.Open();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = @"update Rent SET
		                                        status = 'Returnd'
		                                            WHERE ID = @ID;";

                    dbCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = Convert.ToInt32(ID);

                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
        }

    }
}
