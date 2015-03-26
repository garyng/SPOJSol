// Adding Reversed Numbers
// 2015-03-27 00:29
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJSol
{
	class Program
	{
		static void Main(string[] args)
		{
			int caseNum = int.Parse(Console.ReadLine());
			for (int i = 0; i < caseNum; i++)
			{
				string cases = Console.ReadLine();

				string[] strCase = cases.Split(' ');
				int sum = int.Parse(reverseString(strCase[0])) + int.Parse(reverseString(strCase[1]));
				sum = int.Parse(reverseString(sum.ToString()));
				Console.WriteLine(sum);
			}
		}

		static string reverseString(string str)
		{
			char[] c = str.ToCharArray();
			Array.Reverse(c);
			return new string(c);
		}

	}
}
