// Factorial - Number of zeros
// 2015-03-27 00:28
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID11
{
	class Program
	{
		static void Main(string[] args)
		{
			int caseNum = int.Parse(Console.ReadLine());
			for (int i = 0; i < caseNum; i++)
			{
				string cases = Console.ReadLine();
				int num = int.Parse(cases);

				Console.WriteLine(noOfZeros(num));

			}
		}

		static int noOfZeros(int num)
		{
			double n = num;
			int noOf0 = 0;
			while (Math.Floor(n / 5) > 0)
			{
				n = Math.Floor(n / 5);
				noOf0 += (int)n;
			}
			return noOf0;
		}
	}
}
