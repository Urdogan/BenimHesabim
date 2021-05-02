using System;
using System.ComponentModel.DataAnnotations;

namespace BenimHesabim.Models
{
    public class Log
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public Customer Sender { get; set; }
        public Customer Receiver { get; set; }
        public DateTime Date { get; set; }
    }
}
