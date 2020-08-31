using System;
using System.Collections.Generic;
using System.Text;
using Clean.Architecture.Application.ViewModels;
using Clean.Architecture.Application.ViewModels.Account;
using Clean.Architecture.Domain.Models;

namespace Clean.Architecture.Application.Interfaces
{
  public interface IUserService
  {
      CheckUser CheckUser(string userName, string email);
      int RegisterUser(User user);
      bool IsExistUser(string email, string password);
  }
}
