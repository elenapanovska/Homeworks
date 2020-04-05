using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.Homework.ATM.Business.Models
{
   public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  CardNumber { get; set; }
        public int Pin { get; set; }
        public int BalanceOfMoney { get; set; }

        public Customer(string firstName, string lastName, string cardNmber, int pin, int balanceOfmoney)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNmber;
            Pin = pin;
            BalanceOfMoney = balanceOfmoney;
        }
        public Customer()
        {

        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }



    }
}
