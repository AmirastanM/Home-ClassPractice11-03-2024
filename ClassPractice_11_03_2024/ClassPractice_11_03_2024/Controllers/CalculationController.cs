using ClassPractice_11_03_2024.Helpers.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_11_03_2024.Controllers
{
    internal class CalculationController
    {
        public void GetFactorial()
        {
			try
			{
                int number = -5;
                Console.WriteLine(number.FactorialNamber());
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
            }
        }
    }
}
