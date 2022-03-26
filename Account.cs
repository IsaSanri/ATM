using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Account
    {
        public int idAccount { get; set; }
        public string AccountType { get; set; }
        public string status { get; set; }
        public int Balance { get; set; }
        public int noCard { get; set; }

   
        public int Withdraw(int amount)
    {
        Balance -= amount;
        return Balance;

    }

        public int Deposit(int amount)
    {
        Balance += amount;
        return Balance;

    }

        public Account(int initialBalance, string typeAccount)
    {
        Balance = initialBalance;
        AccountType = typeAccount;

    }
}
    


}
