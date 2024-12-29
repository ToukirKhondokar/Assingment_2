using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    public class CreditCard
    {
        public const decimal MAX_TRANSACTION_LIMIT = 500000m;
        public const decimal PER_DAY_TRANSACTION_LIMIT = 100000m;
        public const decimal PER_TRANSACTION_LIMIT = 20000m;

        private decimal _dailyTransactedAmount = 0m;
        private decimal _totalTransactedAmount = 0m;


        public void Withdraw(decimal amount)
        {
            bool isSuccessful = false;

            if (amount <= 0)
            {
                throw new ArgumentException("amount can not be zero or negetive");
            }

            if (amount > PER_TRANSACTION_LIMIT)
            {
                throw new ArgumentException("per transcation limit exceed");
            }

            if (ValidatePerDayTransactionLimit(amount))
            {
                throw new ArgumentException("per day transaction limit exceed");
            }

            if (ValidateMaxTransactionLimit(amount))
            {
                throw new ArgumentException("max transaction limit exceed");
            }

            _dailyTransactedAmount += amount;
            _totalTransactedAmount += amount;
            isSuccessful = true;
            Console.WriteLine($"Transaction Sucessful");
            //return isSuccessful;
        }

        public void PayBill(decimal amount)
        {
            //bool isSuccessful = false;

            if (amount <= 0)
            {
                throw new ArgumentException("amount can not be zero or negetive");
            }

            if (ValidateMaxTransactionLimit(amount))
            {
                throw new ArgumentException("max transaction limit exceed");
            }

            _totalTransactedAmount += amount;
            //return isSuccessful;
            Console.WriteLine($"Bill Patment Sucessful");

        }


        private bool ValidatePerDayTransactionLimit(decimal amount) => (_dailyTransactedAmount + amount) > PER_DAY_TRANSACTION_LIMIT;
        private bool ValidateMaxTransactionLimit(decimal amount) => (_dailyTransactedAmount + amount) > PER_DAY_TRANSACTION_LIMIT;


        

    }
}
