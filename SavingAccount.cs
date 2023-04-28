using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverridingNew2
{
    public class SavingAccount : BankAccount
    {
        //SavingsAccount

        //Fields
        //interest(double )
        double _interest = 100;

        //Constructor
        //Using the base constructor and add the interest parameter
        public SavingAccount(string name) : base(name)
        {
              
        }

        //Property
        //interest
        //{ get; set; }
        public double Interest { get => _interest; set => _interest = value; }

        //Method
        //override Deposit : If deposit is successful add interest to the account
        //override ToString: Add Interest to base.ToString();

        public override bool Deposit(double amount)
        {
            _interest += amount;
            return true;
        }

        public override string ToString()
        {
            return $"An Interest amount was added to your Saving Account of {_interest} \n" + base.ToString();
        }








    }
}
