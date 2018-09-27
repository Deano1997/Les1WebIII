using Banking.Models.Domain;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBA = new BankAccount("123-123123123-23")
            {
                Balance = 50
            };
            BankAccount anotherBA = new BankAccount("456-4564564-99",1000);

            Console.WriteLine($"Balance for anotherBA is {anotherBA.Balance} Euro");
            Console.WriteLine($"The withdrawcost is {BankAccount.WithdrawCost} Euro");


            Console.WriteLine($"Balance is currently {myBA.Balance} Euro"); //string interpolation, gebruik maken van $ voor de string, laat het toestaan naar het verwijzen van methode, single inheritance
            myBA.Deposit(100);
            //myBA.Deposit(500, 2);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            myBA.Withdraw(50);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            myBA.Withdraw(20);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            Console.ReadKey();

        }
    }
}
