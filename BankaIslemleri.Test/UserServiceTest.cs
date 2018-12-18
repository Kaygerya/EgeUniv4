using System;
using BankaIslemleri.Data.Entities;
using BankaIslemleri.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using BankaIslemleri.Data;

namespace BankaIslemleri.Test
{
    [TestClass]
    public class UserServiceTest
    {
        [TestMethod]
        public void CreateUserTest()
        {
            Users user = new Users();
            user.FullName = "Mehmet Akın";
            user.Tel = "05355555555";
            UserService.CreateUser(user);
        }

        [TestMethod]
        public void GetUserById()
        {
            int userId = 1;
            var user = UserService.GetUserById(userId);
            Assert.AreEqual("Mehmet Akın", user.FullName);
        }

        [TestMethod]
        public void InsertBankAccountToUser()
        {
            BankAccounts bankAccount = new BankAccounts();
            bankAccount.AccountNumber = "A00001";
            bankAccount.Amount = 100;
            int userId = 1;

            UserService.InsertBankAccountToUser(bankAccount, userId);

            var user = UserService.GetUserById(userId);
            Assert.AreEqual(1, user.BankAccounts.Where(k=> k.AccountNumber=="A00001").Count());
        }



    }
}
