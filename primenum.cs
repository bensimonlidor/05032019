using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenum
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;

			int sum = 0;

			int m;

			do
			{
				a = Convert.ToInt32(Console.ReadLine());
				m = 2;

				while (a % m != 0)
				{
					m++;

				}
				if (a == m)
				{
					Console.WriteLine("The num is prime");
					sum = sum + a;
				}
				else
				{
					Console.WriteLine("The num is not prime");
				}
				
			}
			while (a== m);

			Console.WriteLine(sum);
		}
	}
}
