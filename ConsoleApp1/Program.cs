using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{


		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 10, 23, 2, 31, 3, 5, 3, 2, 7, 8, 8, 123, 345, 3324, 12, 23, 5, 23, 3, 43, 4, 2, 346, 7, 56, 3, 4 };

			InsertSort(arr);

			foreach (int i in arr)
				Console.Write(i + " ");

			Console.WriteLine();
			Console.WriteLine(BinarySearch(23, arr));

			Console.ReadKey();
		}

		static int BinarySearch(int num, int[] arr)
		{
			int L = 0, R = arr.Length -1;
			while (L <= R)
			{
				int m = (L + R) / 2;

				if (arr[m] < num)
					L = m + 1;
				else
					R = m - 1;
				if (arr[m] == num) return m;
			}
			return -1;

		}
		static void InsertSort(int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				int t = a[i];
				int j = i;
				while(j > 0 && a[j - 1] > t)
				{
					var temp = a[j];
					a[j] = a[j - 1];
					a[j - 1] = temp;
					j--;
				}
			}
		}

		static void BoobleSort(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
				for (int j = 0; j < arr.Length - 1; j++)
				{
					var t = arr[j];
					if (arr[j] > arr[j + 1])
					{
						arr[j] = arr[j + 1];
						arr[j + 1] = t;
					}
				}
		}

		static void Swap(int a, int b)
		{
			var t = a;
			a = b;
			b = t;
			
		}
	}
}
