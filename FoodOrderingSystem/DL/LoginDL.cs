﻿using FoodOrderingSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.DL
{
    class LoginDL
    {
        // This class will open connection with DB and write appropriate queries
        private DBConnection dbCon;
        public LoginDL()
        {
            dbCon = new DBConnection();
        }
        public UserDTO VerifyUserFromDB(LoginDTO lg)
        {
            UserDTO retDTO = new UserDTO();
            try
            {
                //1. Apply validations on client and server side both
                //2. Use parameter passing in queries


                dbCon.Con.Open();
                string queryString = "SELECT * FROM MyUser WHERE UserID=@UserID AND Password=@Password;";
                //string queryString = "SELECT * FROM MyUser WHERE UserID='" + lg.Username + "' AND Password='" + lg.Password + "';";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", lg.Userid);
                com.Parameters.AddWithValue("@Password", lg.Password);

                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    retDTO.Userid = reader["UserID"].ToString();
                    retDTO.Username = reader["Name"].ToString();
                    retDTO.Password = reader["Password"].ToString();
                    retDTO.Role = reader["Status"].ToString();
                    retDTO.Phone = reader[""].ToString();
                    return retDTO;

                }
            }
            catch (SqlException ex)
            {
                return null;

            }
            finally
            {
                dbCon.Con.Close();

            }
            return null;

        }

    }
}

