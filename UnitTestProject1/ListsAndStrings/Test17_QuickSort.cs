using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Implement Quick sort
    /// </summary>
    [TestClass]
    public class Test17_QuickSort
    {
        int [] QuickSort(int[] a, int i, int j)
        {
            if (i < j)
            {
                int pos = Partition(a, i, j);
                QuickSort(a, i, pos - 1);
                QuickSort(a, pos + 1, j);
            }
            return a;
        }

        int Partition(int[] a, int i, int j)
        {
            int pivot = a[j];
            int small = i - 1;

            for (int k = i; k < j; k++)
            {
                if (a[k] <= pivot)
                {
                    small++;
                    Swap(a, k, small);
                }
            }
            Swap(a, j, small + 1);
            return small + 1;
                     }
//        int Swap(int[] a, int k, int small)
//        {
//            int temp;
//            temp = a[k];
//            a[k] = a[small];
//            a[small] = temp;
//        }
//        return ;

//    }
//    [TestMethod]
//        public void TestMethod1()
//        {
//        }
//    }
//}
