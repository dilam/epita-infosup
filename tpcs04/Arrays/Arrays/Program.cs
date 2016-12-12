using System;

namespace Arrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		}

		static int Search(int[] arr, int e)
		{
			int lon = arr.Length;
			int i = 0;

			while (i < lon && (arr [i] != e))
				i++;

			return (i == lon) ? -1 : i;
		}

		static int Minimum(int[] arr)
		{
			int lon = arr.Length;
			int min = 0;

			for (int i = 1; i < lon; i++)
			{
				if (arr [i] < arr [min])
					min = i;
			}

			return (lon == 0) ? -1 : min;
		}

		static void BubbleSort(int[] arr)
		{
			int lon = arr.Length;
			int lonSort = lon - 1;

			for (int i = 0; i < lon; i++)
			{
				for (int j = 0; j < lonSort; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int swap = arr [j];
						arr [j] = arr [j + 1];
						arr [j + 1] = swap;
					}
				}
				lonSort--;
			}
		}
	}
}
