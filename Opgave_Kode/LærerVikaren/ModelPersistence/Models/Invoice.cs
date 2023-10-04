using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPersistence.Models
{
    public class Invoice
    {
        public int? InvoiceNumber { get; set; }
        public DateOnly? Date { get; set; }


        public Invoice(int invoiceNumber, DateOnly date) 
        {
            InvoiceNumber= invoiceNumber;
            Date= date;
        }
    }

}
