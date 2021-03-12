using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_experiment.model
{
<<<<<<< HEAD
    public class Selection
    {
        public void selectionSort(int[] a)
=======
    class Selection
    {
        public void Selection(int[] a)
>>>>>>> a7a60275bdea25efa6b7d9ace0c14c0ed45761cc
        {
            int aux, temp;
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                aux = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[aux])
                    {
                        aux = j;
                    }
                }
                temp = a[aux];
                a[aux] = a[i];
                a[i] = temp;
            }
        }
    }
}
