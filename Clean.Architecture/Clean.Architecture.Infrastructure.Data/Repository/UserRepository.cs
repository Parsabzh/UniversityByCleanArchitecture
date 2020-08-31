using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Domain.Models;
using Clean.Architecture.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Clean.Architecture.Infrastructure.Data.Repository
{
   public class UserRepository:IUserRepository
   {
       private UniversityDbContext _db;

       public UserRepository(UniversityDbContext db)
       {
           _db = db;
       }

       public bool IsExistUser(string email, string password)
       {
           return _db.Users.Any(u => u.Email == email && u.Password == password);
       }

       public void AddUser(User user)
       {
           _db.Users.Add(user);
       }

        public bool IsExistsUserName(string userName)
        {
            return _db.Users.Any(u=>u.UserName==userName);
        }

        public bool IsExistsEmail(string email)
        {
            return _db.Users.Any(u => u.Email == email);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
   }
}
