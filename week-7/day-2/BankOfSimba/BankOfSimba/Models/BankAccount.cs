using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public enum Animal { Lion, Hyena, Vulture, Monkey }

    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public Animal AnimalType { get; set; }

        public BankAccount(string name, decimal balance, Animal animal)
        {
            Name = name;
            Balance = balance;
            AnimalType = animal;
        }

    }

}
