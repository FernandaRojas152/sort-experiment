using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_experiment.model
{
    public class Quicksort
    {
        public int Partition(int[] a, int left, int right)
        {
            int pivot;
            pivot = a[left];
            while (true)
            {
                while (a[left] < pivot)
                {
                    left++;
                }
                while (a[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = a[right];
                    a[right] = a[left];
                    a[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public Double quickSort(int[] a, int start, int end)
        {
            Double time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            int pivot;
            if (start < end)
            {
                pivot = Partition(a, start, end);
                if (pivot > 1)
                {
                    quickSort(a, start, pivot - 1);
                }
                if (pivot + 1 < end)
                {
                    quickSort(a, pivot + 1, end);
                }
            }
            time = DateTimeOffset.Now.ToUnixTimeMilliseconds() - time;
            return time/1000;
        }
    }
}
