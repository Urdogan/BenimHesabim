using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BenimHesabim.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Balance { get; set; }

        public Customer()
        {
            this.Name = "Nazım";
            this.Surname = "Urdoğan";
            this.Balance = 0;
        }


        public bool Withdraw(double amount)
        {
            if (this.Balance > amount)
            {
                this.Balance -= amount;
                return true;
            } else {
                return false;
            }

        }
        public bool Deposit(double amount)
        {
            this.Balance += amount;
            return true;
        }
    }
}
