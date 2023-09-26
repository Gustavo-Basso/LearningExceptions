using BankAccountException.Entities;
using System.Transactions;
using System.Globalization;
using BankAccountException.Entities.Exceptions;

namespace BankAccountException {


    class Promgram { 
    
        static void Main(String[] args) {

            

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, limit);



            Console.WriteLine();

            Console.Write("Enter ammount for withdraw: ");

            double withdraw = double.Parse(Console.ReadLine());



            try {
                account.WithDraw(withdraw);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e) { 
            
                Console.WriteLine("Withdraw error: " + e.Message );
            }

        }
    
    }


}