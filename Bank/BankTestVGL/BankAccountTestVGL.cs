using System;
using Bank_VGL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTestVGL
{
    //Test Class by Vicente García López.
    [TestClass]
    public class BankAccountTestVGL
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        // unit test code
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // preparación del caso de prueba
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccountVGL account = new BankAccountVGL("Mr. Bryan Walton", beginningBalance);
            // acción a probar
            account.Debit(debitAmount);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        // Debit tests
        //Ejercicios 9, 10
        [TestMethod]
        public void Debit_FrozeAccountTest()
        {
            //preparación caso de uso
            double debitAmount = 20.00;
            double beginningBalance = 42.00;
            BankAccountVGL account = new BankAccountVGL("Mr.Steve Roggers", beginningBalance);
            account.FreezeAccount();

            try
            {
                //acción a probar
                account.Debit(debitAmount);
            }
            catch (Exception arg)
            {
                //checking if its throwing the right exception.
                StringAssert.Contains(arg.Message, BankAccountVGL.AccountIsFrozen);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        //Ejercicio 11
        [TestMethod]
        public void Balance_OutofRangeMaxTest()
        {
            //preparación caso de uso
            double debitAmount = 200.00;
            double beginningBalance = 32.00;
            BankAccountVGL account = new BankAccountVGL("Ms.Natasha", beginningBalance);
            
            try
            {
                //acción a probar
                account.Debit(debitAmount);
            }
            catch(ArgumentOutOfRangeException arg)
            {
                //checking if its throwing the right exception.
                StringAssert.Contains(arg.Message, BankAccountVGL.DebitAmountExceedsBalanceMessage);
                return;
            }
            //Ejercicio 13, refactoring code
            Assert.Fail("No exception was thrown.");
        }

        //Ejercicio 11
        [TestMethod]
        public void Balance_OutofRangeMinTest()
        {
            //preparación caso de uso
            double debitAmount = -20.00;
            double beginningBalance = 32.00;
            BankAccountVGL account = new BankAccountVGL("Skinners", beginningBalance);

            //Ejercicio 14
            try
            { 
            //acción a probar
            account.Debit(debitAmount);
            }
            catch(ArgumentOutOfRangeException arg)
            {
                //checking if its throwing the right exception.
                StringAssert.Contains(arg.Message, BankAccountVGL.DebitAmountLessThanZeroMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        //Eejrcicio 15
        [TestMethod]
        public void CreditOutOfRangeTest()
        {
            //preparación caso de uso
            double creditAmount = -14.50;
            double beginningBalance = 28.00;
            BankAccountVGL account = new BankAccountVGL("MessiChikito", beginningBalance);
            
            try
            {
                //acción a probar
                account.Credit(creditAmount);
            }
            catch (ArgumentOutOfRangeException arg)
            {
                //checking if its throwing the right exception.
                StringAssert.Contains(arg.Message, BankAccountVGL.CreditAmountLessThanZeroMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void CreditFrozeAccountTest()
        {
            //preparación caso de uso
            double creditAmount = 20.00;
            double beginningBalance = 42.00;
            BankAccountVGL account = new BankAccountVGL("Mr.Steve Roggers", beginningBalance);
            account.FreezeAccount();
            
            try
            { 
            //acción a probar
            account.Credit(creditAmount);
            }
            catch(Exception arg)
            {
                //checking if its throwing the right exception.
                StringAssert.Contains(arg.Message, BankAccountVGL.AccountIsFrozen);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

    }
}
