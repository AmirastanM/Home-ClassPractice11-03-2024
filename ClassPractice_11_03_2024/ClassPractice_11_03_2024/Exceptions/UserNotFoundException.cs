using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_11_03_2024.Exceptions
{
    internal class UserNotFoundException : Exception
    {
        public UserNotFoundException(string msj) : base(msj) 
        { 
        
        }
        
    }

}

       