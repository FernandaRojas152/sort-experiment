using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using sort_experiment.model;

namespace ExperimentTest
{
    [TestClass]
    public class ExperimentTest
    {
        private Experiment ex;
        private Quicksort qui;
        private int[] arr;
        private Random random = new Random();
        [TestInitialize]
        public void initialize()
        {
            ex = new Experiment();
            qui = new Quicksort();
        }

        //////////////Selection

        public void SetUpScenary()
        {
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            ex.SetArr(arr);
        }
        public void SetUpScenary1()
        {
            arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            ex.SetArr(arr);
        }

        public void SetUpScenary2()
        {
            arr = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            ex.SetArr(arr);
        }

        [TestMethod]
        public void SelectionSort()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary();
                ex.Selection();
            }
        }

        [TestMethod]
        public void SelectionSort1()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary1();
                ex.Selection();
            }
        }

        [TestMethod]
        public void SelectionSort2()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary2();
                ex.Selection();
            }
        }

        //////////////Quick
       
         

        public void SetUpScenary3()
        {
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }

        }
        public void SetUpScenary4()
        {
           arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }

        public void SetUpScenary5()
        {
            arr = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }

        [TestMethod]
        public void QuickSort()
        {
            for(int j = 0; j < 1000; j++)
            {
                SetUpScenary3();
                qui.quickSort(arr,0,arr.Length-1);
                
            }
        }

        [TestMethod]
        public void QuickSor1t()
        {
            for(int j = 0; j < 1000; j++)
            {
                SetUpScenary4();
                qui.quickSort(arr,0,arr.Length-1);
            }
        }

        [TestMethod]
        public void QuickSort2()
        {
            for(int j = 0; j < 1000; j++)
            {
                SetUpScenary5();
                qui.quickSort(arr,0,arr.Length-1);
            }
        }

    }
}
