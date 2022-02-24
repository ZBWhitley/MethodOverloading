using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethodOverloading
{
    internal class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("This program is designed to total two monetary values. ");
			Console.WriteLine("Please input your first value.");
			var num1 = (Convert.ToDecimal(Console.ReadLine()));
			Console.WriteLine("Please input your second value");
			var num2 = (Convert.ToDecimal(Console.ReadLine()));

			decimal answer = Add(num1, num2);
			if (answer <= -2 || answer >= 2) 
			{
                Console.WriteLine($"You have {answer} dollars");
			}
            else { Console.WriteLine($"You have {answer} dollar"); }
			
		}

		public static int Add(int num1, int num2)
		{
			return num1 + num2;
		}

		public static decimal Add(decimal num1, decimal num2)
		{
			return num1 + num2;
		}
		


	}

			

}

















    
