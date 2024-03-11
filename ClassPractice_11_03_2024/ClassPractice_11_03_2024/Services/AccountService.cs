using ClassPractice_11_03_2024.Exceptions;
using ClassPractice_11_03_2024.Models;
using ClassPractice_11_03_2024.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_11_03_2024.Services
{
    internal class AccountService : IAccountService
    {
        private readonly IUserService _userService;
        public AccountService()
        {
            _userService = new UserService();
        }
        public bool SingIn(string email, string password)
        {
            User[] users = _userService.GetAll();

            User existUser = users.FirstOrDefault(m => m.Email == email && m.Password == password);

            return existUser == null ? throw new UserNotFoundException("User notfound") : true;
            
        }
    }
}
