using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_experiment.model
{
    public class Experiment
    {
		private int[] arr;

		public Experiment()
        {

        }

		public int[] GetArr()
		{
			return arr;
		}

		public void SetArr(int[] value)
		{
			arr = value;
		}

		public void generateArray(int n)
        {
			Random random = new Random();
			arr = new int[n];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = random.Next();
			}
		}

		public double Selection()
		{
			Double time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
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
			time = DateTimeOffset.Now.ToUnixTimeMilliseconds() - time;
			return time/1000;
		}
	}
}
