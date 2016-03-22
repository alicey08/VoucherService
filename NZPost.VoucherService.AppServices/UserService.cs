using NZPost.VoucherService.Infrastructure;
using NZPost.VoucherService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.AppServices
{
    public class UserService
    {
        private readonly IUnitOfWork uow;

        public UserService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public List<User> GetAllUsers()
        {
            return uow.Users.ToList();
        }

        public User GetUserDetails(int userId)
        {
            return uow.Users.Where(u => u.Id == userId).FirstOrDefault();
        }

        public void AddUser(User user, List<Access> Accesses)
        {
            //add accessed to this user first

            uow.Users.Add(user);
            uow.SaveChanges();
        }
    }
}
