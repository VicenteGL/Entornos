using System;

namespace Bank_VGL
{
    /// <summary>
    /// Bank Account demo class.
    /// </summary>
    public class BankAccountVGL
    {
            private string m_customerName;
            private double m_balance;
            private bool m_frozen = false;

        //cool class under test, Ejercicio 13
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance.";
        public const string DebitAmountLessThanZeroMessage = "Debit amount less than zero.";

        public const string AccountIsFrozen = "Account is frozen and the action couldn't be processed";
        public const string CreditAmountLessThanZeroMessage = "Credit amount less than zero.";

        private BankAccountVGL()
            {
            }
            public BankAccountVGL(string customerName, double balance)
            {
                m_customerName = customerName;
                m_balance = balance;
            }
            public string CustomerName
            {
                get { return m_customerName; }
            }
            public double Balance
            {
                get { return m_balance; }
            }
            public void Debit(double amount)
            {
                if (m_frozen)
                {
                    throw new Exception(AccountIsFrozen);
                }
                if (amount > m_balance)
                {
                    // lanzamos excepción sobre la varibale amount
                    throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
                }
                if (amount < 0)
                {
                    // lanzamos excepción sobre la varibale amount
                    throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
                }
                m_balance -= amount; // intentionally incorrect code, was incorrect with +=
            }
            public void Credit(double amount)
            {
                if (m_frozen)
                {
                    throw new Exception(AccountIsFrozen);
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(CreditAmountLessThanZeroMessage);
                }
                m_balance += amount;
            }
            public void FreezeAccount()
            {
                m_frozen = true;
            }
            public void UnfreezeAccount()
            {
                m_frozen = false;
            }
            public static void Main()
            {
                BankAccountVGL ba = new BankAccountVGL("Mr. Bryan Walton", 11.99);
                ba.Credit(5.77);
                ba.Debit(11.22);
                Console.WriteLine("Current balance is ${0}", ba.Balance);
            }
    }
}
