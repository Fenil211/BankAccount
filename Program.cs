using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount   // By default class will be internal
    {
        // Declare fields
        private double _balance = 0.0;  // Default value of _balance is 0.0
        private int _accountNo;
        private string _name;

        // Declare methods
        public void SetNameAndAccount(string _name, int accNo) 
        {
            this._name = _name;             // this keyword represents the current object of a class in C#.
            _accountNo = accNo;
        }

        public void Deposit(double amount) 
        {
            _balance = _balance + amount;  // _balance += amount;
        }

        public void Withdraw(double amount)
        {
            _balance = _balance - amount;
        }

        public void TransferAmount(BankAccount beneficiary, double amount) 
        {
            beneficiary._balance += amount;     // beneficiary's balance will be incremented 
            this._balance -= amount;            // current object's balance will be decremented
        } 

        public void AccountInfo()
        {
            Console.WriteLine("Account Name: {0}, Account Number: {1}, Balance: {2}", _name, _accountNo, _balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount Fenil = new BankAccount();      // Create an object named Fenil
            Fenil.SetNameAndAccount("Fenil", 1001);     // Set name and account number  
            Fenil.Deposit(1000);                        // Deposit $1000 money
            Fenil.AccountInfo();

            BankAccount Taral = new BankAccount();      // Create another object named Taral
            Taral.SetNameAndAccount("Taral", 1002);
            Taral.Deposit(500);
            Taral.AccountInfo();

            Fenil.TransferAmount(Taral, 250);           // Transferring money from Fenil's object to Taral's object
            Console.WriteLine("After transfer: ");
            Fenil.AccountInfo();
            Taral.AccountInfo();

            Console.Read();
        }
    }
}