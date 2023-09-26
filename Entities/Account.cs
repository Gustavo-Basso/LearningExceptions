using BankAccountException.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountException.Entities {
    internal class Account {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }
        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double deposit) {

            Balance += deposit;
        }

        public void WithDraw (double withDraw) {

            if (WithDrawLimit < withDraw) { 
            
                throw new DomainException (" The amount exceeds withdraw limit");
            
            }
            if (Balance < withDraw) {

                throw new DomainException(" Not enough balance");
            }
            Balance -= withDraw;

        }


    }
}
