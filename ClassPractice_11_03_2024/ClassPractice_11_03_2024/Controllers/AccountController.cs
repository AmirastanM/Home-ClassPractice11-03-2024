using ClassPractice_11_03_2024.Services;
using ClassPractice_11_03_2024.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_11_03_2024.Controllers
{
    internal class AccountController 
    {
        private readonly IAccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void SignIn()
        {
            string email = "test@gmail.com";
            string password = "fatime123";

            try
            {
                if (!email.Contains('@'))
                {
                    throw new InvalidCastException("Email format is wrong");
                }
                bool response = _accountService.SingIn(email, password);

                if (response)
                {
                    Console.WriteLine("SignIn in success");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

           
           
        }
    }
}
