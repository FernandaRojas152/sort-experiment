using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using sort_experiment.model;

namespace ExperimentTest
{
    [TestClass]
    public class ExperimentTest
    {
        private int[] arr;
        private Random random = new Random();


        [TestMethod]
        public void SetUpScenary()
        {
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
           Experiment.SetArr(arr);
        }

        [TestMethod]
        public void SetUpScenary1()
        {
            arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Experiment.SetArr(arr);
        }

        [TestMethod]
        public void SetUpScenary2()
        {
            arr = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Experiment.SetArr(arr);
        }

        [TestMethod]
        public void SelectionSort()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary();
                Experiment.Selection();
            }
        }

        [TestMethod]
        public void SelectionSort1()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary1();
                Experiment.Selection();
            }
        }

        [TestMethod]
        public void SelectionSort2()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary2();
                Experiment.Selection();
            }
        }
    }
}
