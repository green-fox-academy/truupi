using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public enum Animal { Lion, Hyena, Parrot, Monkey }

    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public Animal AnimalType { get; set; }
        public bool IsKing { get; set; } = false;
        public bool IsGood { get; set; }

        public BankAccount(string name, decimal balance, Animal animal, bool isGood, bool isKing)
        {
            Name = name;
            Balance = balance;
            AnimalType = animal;
            IsGood = isGood;
            IsKing = isKing;
        }

        public BankAccount(string name, decimal balance, Animal animal, bool isGood)
        {
            Name = name;
            Balance = balance;
            AnimalType = animal;
            IsGood = isGood;
        }
    }

}
