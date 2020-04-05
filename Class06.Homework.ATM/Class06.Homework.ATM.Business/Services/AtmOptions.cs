using Class06.Homework.ATM.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.Homework.ATM.Business.Services
{
    public class AtmOptions
    {

        public void HelloMessage(string cardNum, int cardPin, Customer[] customers)
        {
            Customer custumer1 = new Customer();

            foreach (Customer custumer in customers)
            {
                if (cardNum == custumer.CardNumber && cardPin == custumer.Pin)
                {
                    custumer1 = custumer;
                }
            }

            Console.WriteLine($"Hello {custumer1.GetFullName()}");
        }

        public void BlanceChecking(string cardNum, int cardPin, Customer[] custumers)
        {
            Customer custumer1 = new Customer();

            foreach (Customer custumer in custumers)
            {
                if (cardNum == custumer.CardNumber && cardPin == custumer.Pin)
                {
                    custumer1 = custumer;
                }
            }
            Console.WriteLine($"Your current balance is {custumer1.BalanceOfMoney}");
        }

        public void CashWithdraw(string cardNum, int cardPin, Customer[] custumers)
        {
            Customer custumer1 = new Customer();

            foreach (Customer custumer in custumers)
            {
                if (cardNum == custumer.CardNumber && cardPin == custumer.Pin)
                {
                    custumer1 = custumer;
                }
            }

            Console.WriteLine("How much money wolud you like to withdraw?");
            int cashWitdraw;
            int.TryParse(Console.ReadLine(), out cashWitdraw);

            if (cashWitdraw > custumer1.BalanceOfMoney)
            {
                Console.WriteLine("You do not have enough money on your account!");
            }
            else
            {
                int leftMoney = custumer1.BalanceOfMoney - cashWitdraw;
                Console.WriteLine($"You succesfully withdrawn money. You withdrawn: {cashWitdraw}$ your current balance is {leftMoney}$");
            }
        }

        public void CashDeposition(string cardNum, int cardPin,  Customer[] custumers)
        {
            Customer custumer1 = new Customer();

            foreach (Customer custumer in custumers)
            {
                if (cardNum == custumer.CardNumber && cardPin == custumer.Pin)
                {
                    custumer1 = custumer;
                }
            }

            Console.WriteLine("How much money would you like to deposit?");
            int cashDeposit;
            int.TryParse(Console.ReadLine(), out cashDeposit);

            int newBalnce = custumer1.BalanceOfMoney + cashDeposit;
            Console.WriteLine($"You succesfully deposited {cashDeposit}$ , your new balnace is: {newBalnce}$");
        }
        
        public void RegisterCustomer(string cardNum, Customer[] customers)
        {
            Customer newCustomer = new Customer();
            foreach(Customer custumer in customers)
            {
                if(cardNum == custumer.CardNumber)
                {
                    Console.WriteLine("That card number is already in use!");
                    return;
                }
            }
            Console.WriteLine("Please enter your first name, last name, pin and money balance!");

            newCustomer.FirstName = Console.ReadLine();
            newCustomer.LastName = Console.ReadLine();
            newCustomer.CardNumber = cardNum;
            
            int pin;
            int.TryParse(Console.ReadLine(), out pin);
            newCustomer.Pin = pin;
            int moneyBalance;
            int.TryParse(Console.ReadLine(), out moneyBalance);
            newCustomer.BalanceOfMoney = moneyBalance;

            int newSize = customers.Length;
            Array.Resize(ref customers, newSize + 1);
            customers[newSize - 1] = newCustomer;
        }


    }
}
