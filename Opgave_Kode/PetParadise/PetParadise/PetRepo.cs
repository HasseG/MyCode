using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace PetParadise
{
    public class PetRepo
    {
        private List<Pet> pets = new List<Pet>();
        private string connectionString = "Server=10.56.8.36; database=DB_2023_21; user id=STUDENT_21; password=OPENDB_21;";

        public PetRepo()
        {
            // Load all pet data from database via SQL statements and populate pet repository
            pets = GetAll();
            // IMPLEMENT THIS!
        }

        public int Add(Pet pet)
        {
            // Add new pet to database and to repository
            // Return the database id of the pet

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Pet> GetAll()
        {
            // Retrieve all pets from database

            List<Pet> result = new List<Pet>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT PetId, PetName, PetType, PetBreed, PetDOB, PetWeight FROM PET", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pet pet = new Pet(Int32.Parse(reader["PetId"].ToString()));
                        pet.Name = reader["PetName"].ToString();
                        pet.PetType = (PetTypes)Enum.Parse(typeof(PetTypes), reader["PetType"].ToString());
                        pet.Breed = reader["PetBreed"].ToString();
                        if (reader["PetDOB"].ToString() != "")
                        {
                            pet.DOB = DateTime.Parse(reader["PetDOB"].ToString());
                        }
                        //else
                        //{
                        //    pet.DOB = DateTime.MinValue;
                        //}
                        pet.Weight = double.Parse(reader["PetWeight"].ToString());
                        result.Add(pet);
                    }
                    return result;
                }
            }

            // IMPLEMENT THIS!

            return result;
        }
        public Pet GetById(int id)
        {
            //Get pet by id from database

           List<Pet> tempPetList = GetAll();
            Pet result = null;
            foreach (Pet pet in tempPetList)
            {
                if (id == pet.PetId)
                {
                    return result = pet;
                }

            }

            // IMPLEMENT THIS!

            return result;
        }
        public void Update(Pet pet)
        {
            // Update existing pet on database

            // IMPLEMENT THIS!
        }
        public void Remove(Pet pet)
        {
            // Delete existing pet in database

            // IMPLEMENT THIS!
        }
    }
}
