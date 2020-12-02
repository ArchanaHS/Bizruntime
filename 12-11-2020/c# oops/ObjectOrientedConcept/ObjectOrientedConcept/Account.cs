using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedConcept
{
    class Account
    {
        public int ID;//Fields.
        public string Name;
        private decimal Balance;
        
        //methods


        public void Deposit(decimal ammount)
        {
           this.Balance += ammount;
        }
        public void Withdraw(decimal ammount)
        {
            if (this.Balance - ammount < 500)
            {
                throw new ApplicationException("Insufficent Funds...");

            }
            else
                this.Balance += ammount;
        }
    }
}
