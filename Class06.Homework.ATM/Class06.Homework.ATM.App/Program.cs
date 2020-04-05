using Class06.Homework.ATM.Business.Models;
using Class06.Homework.ATM.Business.Services;
using System;

namespace Class06.Homework.ATM.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var atmOptions = new AtmOptions();   
            Customer[] customers = InitializeCustomers();

            Console.WriteLine("To log in enter 1, to register a new card enter 2! ");
            string logInRegister = Console.ReadLine();
            
            if(logInRegister == "1")
            {
                bool chooseAgain = false;
                bool goodBye = false;
                do
                {
                    Console.WriteLine("Enter your card number and pin!");

                    string cardNum = Console.ReadLine();
                    
                    int cardPin;
                    int.TryParse(Console.ReadLine(), out cardPin);

                   atmOptions.HelloMessage(cardNum, cardPin, customers);

                    ChooseOption(atmOptions, cardNum, cardPin, customers);

                    Console.WriteLine("Do you want to choose anoter option? Yes / No");
                    string again = Console.ReadLine();
                    chooseAgain = (again.ToLower() == "yes");
                    if (goodBye = (again.ToLower() == "no"))
                    {
                        Console.WriteLine("Goodbye!");
                    }
                } while (chooseAgain || goodBye);
            } 
            else if(logInRegister == "2")
            {
                Console.WriteLine("Enter your card number!");
                string newCardNum = Console.ReadLine();
               
                atmOptions.RegisterCustomer(newCardNum, customers);
            }

            Console.ReadLine();
        }

        public static Customer[] InitializeCustomers()
        {
            Customer[] custumers = new Customer[]
            {
                new Customer("Bob", " Bobsky", "2321-3124-4564-5674", 3214, 1000),
                new Customer("Greg", "Doe", "6438-6482-8965-4849", 5232, 2000),
                new Customer("Jill", "Martines", "7843-1034-7845-8956", 8965, 2400),
                new Customer("Anne", "Marie", "5647-6782-1094-4758", 7689, 3800)
            };
            return custumers;
        }

        public static void ChooseOption(AtmOptions atmOptions, string cardNum, int cardPin, Customer[] custumers)
        {
            Console.WriteLine("What would you like to do? To see your balance enter 1, to withdraw cash enter 2 and for cash deposite enter 3!");
            
            int option;
            int.TryParse(Console.ReadLine(), out option);
         
            switch (option)
            {
                case 1:
                    atmOptions.BlanceChecking(cardNum, cardPin, custumers);
                    break;
                case 2:
                    atmOptions.CashWithdraw(cardNum, cardPin, custumers);
                    break;
                case 3:
                    atmOptions.CashDeposition(cardNum, cardPin, custumers);
                    break;
            }

        }



    }
}
