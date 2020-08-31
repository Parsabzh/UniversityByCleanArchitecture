using System;
using System.Collections.Generic;
using System.Text;
using Clean.Architecture.Application.Interfaces;
using Clean.Architecture.Application.Security;
using Clean.Architecture.Application.ViewModels;
using Clean.Architecture.Application.ViewModels.Account;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Domain.Models;

namespace Clean.Architecture.Application.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public CheckUser CheckUser(string userName, string email)
        {
            var userNameValid = _userRepository.IsExistsUserName(userName);
            var emailValid = _userRepository.IsExistsEmail(email.Trim().ToLower());
          
             if (userNameValid && emailValid)
                return ViewModels.Account.CheckUser.UserNameAndEmailNotValid;

             else if (emailValid)
                 return ViewModels.Account.CheckUser.EmailNotValid;
             else if (userNameValid)
                 return ViewModels.Account.CheckUser.UserNameNotValid;

             return ViewModels.Account.CheckUser.Ok;

        }

        public int RegisterUser(User user)
        {
            _userRepository.AddUser(user);
            _userRepository.Save();
            return user.UserId;
        }

        public bool IsExistUser(string email, string password)
        {
            return _userRepository.IsExistUser(email.Trim().ToLower(), PasswordHelper.EncodePasswordMd5(password));
        }
    }
}
