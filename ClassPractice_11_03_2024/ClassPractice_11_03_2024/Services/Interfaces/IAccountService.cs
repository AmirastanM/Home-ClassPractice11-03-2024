using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_11_03_2024.Services.Interfaces
{
    internal interface IAccountService
    {
        bool SingIn(string email, string password);
    }
}
