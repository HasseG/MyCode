using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Linq;


namespace PetParadise
{
    public class OwnerRepo
    {
        private List<Owner> owners = new List<Owner>();

        private string connectionString = "Server=10.56.8.36; database=DB_2023_21; user id=STUDENT_21; password=OPENDB_21;";
        public OwnerRepo()
        {
            owners = GetAll();

            // IMPLEMENT THIS!
        }

        public int Add(Owner owner)
        {
            // Add new owner to database and to repository
            // Return the database id of the owner

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Owner> GetAll()
        {
            // Retrieve all owners from database

            List<Owner> result = new List<Owner>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT OwnerId, OwnerFirstName, OwnerLastName, OwnerPhone, OwnerEmail FROM OWNER", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Owner owner = new Owner(Int32.Parse(reader["OwnerId"].ToString()));
                        owner.FirstName = reader["OwnerFirstName"].ToString();
                        owner.LastName = reader["OwnerLastName"].ToString();
                        owner.Phone = reader["OwnerPhone"].ToString();
                        owner.Email = reader["OwnerEmail"].ToString();
                        result.Add(owner);
                    }
                    return result;
                }
            }
        }

        public Owner GetById(int id)
        {
            // Get owner by id from database

            List<Owner> tempList = GetAll();
            foreach(Owner owner in tempList)
            {
                if (id == owner.OwnerId)
                {
                    return owner;
                } 
            }
            return null;
        }
        public void Update(Owner owner)
        {
            // Update existing owner on database

            // IMPLEMENT THIS!
        }
        public void Remove(Owner owner)
        {
            // Delete existing owner in database

            // IMPLEMENT THIS!
        }

    }
}

