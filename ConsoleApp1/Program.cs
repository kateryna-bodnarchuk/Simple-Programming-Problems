using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            void MergeSort(int[] a, int left, int right)
            {
                int middle = 0;

                if (right > left)
                {
                    middle = (left + right) / 2;
                    MergeSort(a, left, middle);
                    MergeSort(a, middle + 1, right);
                    Merge(a, left, middle + 1, right);
                }
            }
            int[] Merge(int[] a, int left, int middle, int right)
            {
                int[] temp = new int[a.Length];
                int leftEndIndex = middle - 1;
                int sourceIndex = left;
                int source = (right - left + 1);

                while (left <= middle && middle <= right)
                {
                    if (a[left] <= a[middle])
                    {
                        temp[sourceIndex++] = a[left++];
                    }
                    else
                    {
                        temp[sourceIndex++] = a[middle++];
                    }
                }
                while (left <= leftEndIndex)
                    temp[sourceIndex++] = a[left++];

                while (middle <= right)
                {
                    temp[sourceIndex++] = a[middle++];
                }
                for (int i = 0; i <= source; i++)
                {
                    a[right] = temp[right];
                    right--;
                }
                return a;
            }
        }
    }
}