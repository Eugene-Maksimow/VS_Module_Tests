using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Это класс теста для BankAccountTest, в котором должны
    ///находиться все модульные тесты BankAccountTest
    ///</summary>
    [TestClass()]
    public class BankAccountTest {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для Debit
        ///</summary>
        [TestMethod()]
        public void DebitTest() {
            BankAccount target = new BankAccount("Mr.Bryan Walton", 11.99);
            double amount = 11.22;
            target.Debit(amount);
           // Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
            Assert.AreEqual((System.Convert.ToDouble(0.77)), target.Balance, 0.05);

        }

        /// <summary>
        ///Тест для Credit
        ///</summary>
        [TestMethod()]
        public void CreditTest() {
            BankAccount target = new BankAccount("Mr.Bryan Walton", 11.99);
            double amount = 11.22;
            target.Credit(amount);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для FreezeAccount
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bank.dll")]
        public void FreezeAccountTest() {
            BankAccount_Accessor target = new BankAccount_Accessor("Mr.Bryan Walton", 11.99); // TODO: Initialize to an appropriate value
            target.FreezeAccount();
            // Assert.Inconclusive("A method that does not return a value cannot be verified.");        bool creditAccount = false; // False means account could be credited: Fail test.     // Try to credit account    try    {        target.Credit(1.00);     }    catch (System.Exception)    {// Threw exception.FreezeAccount worked correctly: Pass test.        creditAccount = true;    }    // Assert fails if 'creditAccount' condition is false.Fail test.    Assert.IsTrue(creditAccount, "Was able to credit account.");
        }
    }
}
