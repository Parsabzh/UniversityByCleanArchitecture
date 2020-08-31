using System;
using System.Collections.Generic;
using System.Text;
using Clean.Architecture.Domain.Models;

namespace Clean.Architecture.Domain.Interfaces
{
   public interface IUserRepository
   {
       bool IsExistUser(string email, string password);


       void AddUser(User user);
       bool IsExistsUserName(string userName);
       bool IsExistsEmail(string email);
       void Save();
   }
}
