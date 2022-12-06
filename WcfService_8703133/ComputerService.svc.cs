using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Diagnostics;

namespace WcfService_8703133
{
    public class ComputerService : IComputerService
    {
        public List<Computer> GetAllComputers()
        {
            List<Computer> allComputers = new List<Computer>();
            DataSet computerData = new DataSet();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=localhost;" +
              "Initial Catalog=wcf_assignment3;" +
              "Integrated Security=True;" +
              "TrustServerCertificate = True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Computer", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(computerData);

            cmd.ExecuteNonQuery();
            conn.Close();

            for(int row = 0; row < computerData.Tables[0].Rows.Count; row++)
            {
                Computer computer = new Computer();
                computer.Uuid = computerData.Tables[0].Rows[row][0].ToString();
                computer.Name = computerData.Tables[0].Rows[row][1].ToString();
                if (String.IsNullOrEmpty(computerData.Tables[0].Rows[row][2].ToString()))
                    computer.ImageUrl = "";
                else
                {
                    computer.ImageUrl = computerData.Tables[0].Rows[row][2].ToString();
                }
                computer.Quantity = int.Parse(computerData.Tables[0].Rows[row][3].ToString());
                computer.Price = double.Parse(computerData.Tables[0].Rows[row][4].ToString());
                computer.Os = int.Parse(computerData.Tables[0].Rows[row][5].ToString());
                computer.HardDrive = computerData.Tables[0].Rows[row][6].ToString();
                computer.ScreenSize = computerData.Tables[0].Rows[row][7].ToString();
                computer.Brand = int.Parse(computerData.Tables[0].Rows[row][8].ToString());
                computer.DisplayResolution = computerData.Tables[0].Rows[row][9].ToString();
                computer.Ram = computerData.Tables[0].Rows[row][10].ToString();

                allComputers.Add(computer);
            }
            
            return allComputers;
        }

        public List<Brand> GetAllBrands()
        {
            List<Brand> allBrands = new List<Brand>();
            DataSet brandData = new DataSet();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=localhost;" +
              "Initial Catalog=wcf_assignment3;" +
              "Integrated Security=True;" +
              "TrustServerCertificate = True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Brand", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(brandData);

            cmd.ExecuteNonQuery();
            conn.Close();

            for (int row = 0; row < brandData.Tables[0].Rows.Count; row++)
            {
                Brand brand = new Brand();
                brand.Id = int.Parse(brandData.Tables[0].Rows[row][0].ToString());
                brand.Name = brandData.Tables[0].Rows[row][1].ToString();


                allBrands.Add(brand);
            }

            return allBrands;
        }
        public List<OS> GetAllOses()
        {
            List<OS> allOses = new List<OS>();
            DataSet brandData = new DataSet();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=localhost;" +
              "Initial Catalog=wcf_assignment3;" +
              "Integrated Security=True;" +
              "TrustServerCertificate = True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from OS", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(brandData);

            cmd.ExecuteNonQuery();
            conn.Close();

            for (int row = 0; row < brandData.Tables[0].Rows.Count; row++)
            {
                OS brand = new OS();
                brand.Id = int.Parse(brandData.Tables[0].Rows[row][0].ToString());
                brand.Name = brandData.Tables[0].Rows[row][1].ToString();


                allOses.Add(brand);
            }

            return allOses;
        }

        public Computer GetComputer(string uuid)
        {
            Computer computer = new Computer();
            DataSet computerData = new DataSet();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=localhost;" +
              "Initial Catalog=wcf_assignment3;" +
              "Integrated Security=True;" +
              "TrustServerCertificate = True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Computer where UUID = @UUID", conn);
            cmd.Parameters.AddWithValue("@UUID", uuid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(computerData);

            cmd.ExecuteNonQuery();
            conn.Close();

            
            computer.Uuid = computerData.Tables[0].Rows[0][0].ToString();
            computer.Name = computerData.Tables[0].Rows[0][1].ToString();
            if (String.IsNullOrEmpty(computerData.Tables[0].Rows[0][2].ToString()))
                computer.ImageUrl = "";
            else
            {
                computer.ImageUrl = computerData.Tables[0].Rows[0][2].ToString();
            }
            computer.Quantity = int.Parse(computerData.Tables[0].Rows[0][3].ToString());
            computer.Price = double.Parse(computerData.Tables[0].Rows[0][4].ToString());
            computer.Os = int.Parse(computerData.Tables[0].Rows[0][5].ToString());
            computer.HardDrive = computerData.Tables[0].Rows[0][6].ToString();
            computer.ScreenSize = computerData.Tables[0].Rows[0][7].ToString();
            computer.Brand = int.Parse(computerData.Tables[0].Rows[0][8].ToString());
            computer.DisplayResolution = computerData.Tables[0].Rows[0][9].ToString();
            computer.Ram = computerData.Tables[0].Rows[0][10].ToString();


            return computer;
        }

        public string UpdateComputer(Computer computer)
        {
            string Message = "";
            DataSet computerData = new DataSet();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=localhost;" +
              "Initial Catalog=wcf_assignment3;" +
              "Integrated Security=True;" +
              "TrustServerCertificate = True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Computer SET name = @Name, imageUrl = @ImageUrl, quantity = @Quantity, price = @Price, os = @Os, hard_drive = @HardDrive, screen_size = @ScreenSize, brand = @Brand, display_resolution = @DisplayResolution, ram = @Ram WHERE UUID = @UUID", conn);
            cmd.Parameters.AddWithValue("@UUID", computer.Uuid);
            cmd.Parameters.AddWithValue("@Name", computer.Name);
            if (String.IsNullOrEmpty(computer.ImageUrl))
            {
                computer.ImageUrl = "";
            }
            cmd.Parameters.AddWithValue("@ImageUrl", computer.ImageUrl);
            cmd.Parameters.AddWithValue("@Quantity", computer.Quantity);
            cmd.Parameters.AddWithValue("@Price", computer.Price);
            cmd.Parameters.AddWithValue("@Os", computer.Os);
            cmd.Parameters.AddWithValue("@HardDrive", computer.HardDrive);
            cmd.Parameters.AddWithValue("@ScreenSize", computer.ScreenSize);
            cmd.Parameters.AddWithValue("@Brand", computer.Brand);
            cmd.Parameters.AddWithValue("@DisplayResolution", computer.DisplayResolution);
            cmd.Parameters.AddWithValue("@Ram", computer.Ram);

            int result = cmd.ExecuteNonQuery();
            conn.Close();
            
            if(result == 1)
            {
                Message = computer.Name + " Details updated successfully";
            }
            else
            {
                Message = computer.Name + " Details updation failed";
            }

            return Message;
        }

        public string AddComputer(Computer computer)
        {
            Guid myuuid = Guid.NewGuid();
            computer.Uuid = myuuid.ToString();
            string Message = "";
            DataSet computerData = new DataSet();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=localhost;" +
              "Initial Catalog=wcf_assignment3;" +
              "Integrated Security=True;" +
              "TrustServerCertificate = True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Computer (UUID, name, imageUrl, quantity, price, os, hard_drive, screen_size, brand, display_resolution, ram)" +
                "VALUES (@UUID, @Name, @ImageUrl, @Quantity, @Price, @Os, @HardDrive, @ScreenSize, @Brand, @DisplayResolution, @Ram);", conn);
            cmd.Parameters.AddWithValue("@UUID", computer.Uuid);
            cmd.Parameters.AddWithValue("@Name", computer.Name);
            if (String.IsNullOrEmpty(computer.ImageUrl))
            {
                computer.ImageUrl = "";
            }
            cmd.Parameters.AddWithValue("@ImageUrl", computer.ImageUrl);
            cmd.Parameters.AddWithValue("@Quantity", computer.Quantity);
            cmd.Parameters.AddWithValue("@Price", computer.Price);
            cmd.Parameters.AddWithValue("@Os", computer.Os);
            cmd.Parameters.AddWithValue("@HardDrive", computer.HardDrive);
            cmd.Parameters.AddWithValue("@ScreenSize", computer.ScreenSize);
            cmd.Parameters.AddWithValue("@Brand", computer.Brand);
            cmd.Parameters.AddWithValue("@DisplayResolution", computer.DisplayResolution);
            cmd.Parameters.AddWithValue("@Ram", computer.Ram);

            int result = cmd.ExecuteNonQuery();
            conn.Close();

            if (result == 1)
            {
                Message = computer.Name + " Details added successfully";
            }
            else
            {
                Message = computer.Name + " Details adding operation failed";
            }

            return Message;
        }

        public string DeleteComputer(string uuid)
        {
            string Message = "";
            DataSet computerData = new DataSet();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=localhost;" +
              "Initial Catalog=wcf_assignment3;" +
              "Integrated Security=True;" +
              "TrustServerCertificate = True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Computer WHERE UUID = @UUID", conn);
            cmd.Parameters.AddWithValue("@UUID", uuid);

            int result = cmd.ExecuteNonQuery();
            conn.Close();

            if (result == 1)
            {
                Message = "Computer was deleted successfully";
            }
            else
            {
                Message = "Computer deletion failed";
            }

            return Message;
        }
    }
}
