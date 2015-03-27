// Number Steps
// 2015-03-27 09:30
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID1112
{
	class Program
	{
		static void Main(string[] args)
		{
			int caseNum = int.Parse(Console.ReadLine());
			for (int i = 0; i < caseNum; i++)
			{
				string cases = Console.ReadLine();
				string[] c = cases.Trim().Split(' ');
				if (checkGotValue(int.Parse(c[0]), int.Parse(c[1])))
				{
					Console.WriteLine(calValue(int.Parse(c[0]), int.Parse(c[1])));
				}
				else
				{
					Console.WriteLine("No Number");
				}
			}
		}

		static int calValue(int x, int y)
		{
			if (x == y)
			{
				if (x % 2 == 0)
				{

					return 2 * x;
				}
				else
				{
					return x + y - 1;
				}
			}
			else
			{
				if ((x - 2) % 2 == 0)
				{
					return 2 * (x - 2) + 2;
				}
				else
				{
					return x + y - 1;
				}
			}

		}

		static bool checkGotValue(int x, int y)
		{
			return y == (x - 2) || y == x;
		}
	}
}
