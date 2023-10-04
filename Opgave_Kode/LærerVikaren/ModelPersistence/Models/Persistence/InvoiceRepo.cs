using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPersistence.Models.Persistence
{
    public class InvoiceRepo
    {
        private List<Invoice> invoices = new List<Invoice>();
        private string databaseConnectionString = "Server = 10.56.8.36; Database=DB_2023_21; User Id = STUDENT_21; Password=OPENDB_21";

        public void SaveListToDatabase()
        {
            using (SqlConnection con = new SqlConnection(databaseConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT InvoiceNumber, InDate FROM INVOICE;", con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        
                    }
                }
            }
        }

        public void LoadDatabaseToList()
        {
            using (SqlConnection con = new SqlConnection(databaseConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT InvoiceNumber, InDate FROM INVOICE;", con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Invoice invoice = new Invoice(Int32.Parse((string)dr["InvoiceNumber"]), DateOnly.Parse((string)dr["InDate"]));
                        invoices.Add(invoice);
                    }
                }
            }
        }
        
        public void AddInvoice(Invoice invoice)
        {

        }

        public List<Invoice> GetAllInvoices()
        {
            return invoices;
        }

        public Invoice GetInvoiceById(int invoiceNumber)
        {
            return null;
        }

        public void UpdateInvoiceById(int invoiceNumber)
        {

        }

        public void DeleteInvoiceById(int id) 
        {

        }

    }
}
