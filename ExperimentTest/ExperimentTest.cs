using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using sort_experiment.model;

namespace ExperimentTest
{
    [TestClass]
    public class ExperimentTest
    {
        private Experiment ex;
        private int[] arr;
        private Random random = new Random();
        [TestInitialize]
        public void initialize()
        {
            ex = new Experiment();
        }

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
    }
}
