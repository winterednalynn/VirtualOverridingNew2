using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VirtualOverridingNew2
{
   public class BankAccount
    {
        //BankAccount

        //FIELDS 

        string _name;
        int _accountNumber;
        double _balance;

        Random rand = new Random();

        //CONSTRUCTOR 
        public BankAccount(string name)
        {
            Name = name;

            _accountNumber = rand.Next(452548, 525465);
        }

        //Properties
        //Name
        //{ get; set; }
        //AccountNumber and Balance { get; }
        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { get => _accountNumber;  }
        public double Balance { get => _balance;}

        //Methods
        //virtual bool Deposit(double amount) :
        //Add Money(make sure to validate if amount is positive )
        //Return true if the transaction goes through
        //Return false if the amount is negative
        public virtual bool Deposit(double amount)
        {
            if(amount > 0)
            {
                _balance += amount;
            }
            else
            {
                return false; 
            }
            return true; 
        }
        //virtual bool Withdraw(double amount) :
        //Subtract From Balance(Validate for positive amount and if there is enough money in the account)
        //Return true if the transaction goes through
        //Return false if the amount is negative or if there is not enough money in the account
        public virtual bool Withdraw(double amount)
        {
            if (amount > 0 && _balance >=0)
            {
                _balance -= amount;

            }
            else if(amount > _balance)
            {
                //When account is negative , it will prompt as negative integer. 
            }
   
            return false;


        }
        //Override ToString
        //this.GetType() - Display Name - Account Number - Balance
        public override string ToString()
        {
            return this.GetType() + $"\n Name {_name}  - Account Number {_accountNumber} - Balance {_balance}"; 
        }





      
    }
}
