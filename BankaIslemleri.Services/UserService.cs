using BankaIslemleri.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Services
{
    public static class UserService
    {
        public static void CreateUser(Users user)
        {
            BankaIslemleriEntities entities = new BankaIslemleriEntities();
            entities.Users.Add(user);
            entities.SaveChanges();
        }

        public static Users GetUserById(int userId)
        {
            if (userId >0)
            {
                BankaIslemleriEntities entities = new BankaIslemleriEntities();
                var user = entities.Users.Where(k => k.Id == userId).FirstOrDefault();
                return user;
            }
            else return null;
        }

        public static List<Users> GetAllUsers()
        {
            BankaIslemleriEntities entities = new BankaIslemleriEntities();
            return entities.Users.ToList();
        }

        public static void InsertBankAccountToUser(BankAccounts bankAccount, int userId)
        {
            if (bankAccount != null)
            {
                BankaIslemleriEntities entities = new BankaIslemleriEntities();
                var user = GetUserById(userId);
                if (user != null)
                {
                    entities.Users.Where(k => k.Id == userId).FirstOrDefault().BankAccounts.Add(bankAccount);
                    entities.SaveChanges();
                }
            }
        }

        public static void UpdateUser(Users user)
        {
            BankaIslemleriEntities entities = new BankaIslemleriEntities();
            entities.SaveChanges();
        }
    }
}
