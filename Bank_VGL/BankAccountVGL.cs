﻿using System;

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
                    throw new Exception("Account frozen");
                }
                if (amount > m_balance)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }
                m_balance += amount; // intentionally incorrect code
            }
            public void Credit(double amount)
            {
                if (m_frozen)
                {
                    throw new Exception("Account frozen");
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException("amount");
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