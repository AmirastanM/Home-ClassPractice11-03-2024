using ClassPractice_11_03_2024.Models;
using ClassPractice_11_03_2024.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_11_03_2024.Services
{
    internal class UserService : IUserService
    {

        public User[] GetAll()
        {
            return new User[]
            {
                new User
                {
                    Id = 1,
                    FullName = "Fatime Qayxanova",
                    Email = "fatime@code.edu.az",
                    Password = "fatime123"
                },
                new User
                {
                    Id = 2,
                    FullName = "Faxriyye Tagizade",
                    Email = "faxriye@code.edu.az",
                    Password = "faxriye123"
                },
                new User
                {
                    Id = 3,
                    FullName = "Afide Veliyeva",
                    Email = "afide@code.edu.az",
                    Password = "afide123"
                }
            };
        }





        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

      

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
