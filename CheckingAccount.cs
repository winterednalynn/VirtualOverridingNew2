using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverridingNew2
{
    public class CheckingAccount : BankAccount
    {

        //CheckingAccount(Inherit from BankAccount

        //Fields
        //overdraft fee (double )
        double _overdraftFee ; 

        //Constructor
        //Implement the base constructor, add parameter for overdraft fee
        public CheckingAccount(string name, double overdraftFee) : base(name)
        {
            OverdraftFee = overdraftFee;
        }

        //Property
        //overdraftFee { get; set; }
        public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }

        //Method
        //override Withdraw(double amount) : If the withdraw fails, have it withdraw the overdraft fee from the _balance;

        public override bool Withdraw(double amount)
        {
            if(base.Balance <= 0)
            {
                _overdraftFee -= Balance;
            }
            return true; 
        }

        //override ToString - Add fee to base.ToString()

        public override string ToString()
        {
            return $" You've been penalize with an Overdraft fee of {_overdraftFee}"; 
        }

    }
}
