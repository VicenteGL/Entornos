using System;
using Bank_VGL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTestVGL
{
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
            BankAccountVGL account = new BankAccountVGL("Mr. Bryan Walton",
            beginningBalance);
            // acción a probar
            account.Debit(debitAmount);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        // Debit tests

        [TestMethod]
        public void Debit_FrozeAccountTest()
        {
            //preparación caso de uso
            double debitAmount = 20.00;
            double beginningBalance = 42.00;
            BankAccountVGL account = new BankAccountVGL("Mr.Steve Roggers", beginningBalance);
            account.FreezeAccount();
            //acción a probar
            account.Debit(debitAmount);
        }


    }
}
