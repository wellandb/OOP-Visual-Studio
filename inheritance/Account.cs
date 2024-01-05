using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Account : Person
    {
        public Account() { }
        public double getAccountBalance()
        {
            return currentAccount;
        }
        public double setAccountBalance(double balance)
        {
            currentAccount += balance;
            return currentAccount;
        }
        public double withdrawFromAccount(double amountToWithdraw)
        {
            currentAccount -= amountToWithdraw;
            return currentAccount;
        }
    }
}
