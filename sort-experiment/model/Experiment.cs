using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_experiment.model
{
    public static class Experiment
    {
		private static int[] arr;

		public static int[] GetArr()
		{
			return arr;
		}

		public static void SetArr(int[] value)
		{
			arr = value;
		}

		public static void Selection()
		{
			int n = arr.Length;

			for (int i = 0; i < n - 1; i++)
			{
				int min_idx = i;
				for (int j = i + 1; j < n; j++)
				{
					if (GetArr()[j] < GetArr()[min_idx])
					{
						min_idx = j;
					}
				}

				int temp = GetArr()[min_idx];
				GetArr()[min_idx] = GetArr()[i];
				GetArr()[i] = temp;
			}
		}
	}
}
