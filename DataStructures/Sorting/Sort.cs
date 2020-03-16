using System;

namespace DataStructures.Sorting
{
    public static class Sort
    {
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivot = array[(left + right) / 2];

            int index = Partition(array, left, right, pivot);

            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }

        public static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {

                while (array[left] < pivot)
                {
                    left++;
                }


                while (array[right] > pivot)
                {
                    right--;
                }


                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }

        public static int[] Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
            return a;
        }

        public static void MergeSort(int[] a, int l, int r)
        {
            if (l < r)
            {
                Console.WriteLine("splitting l r: " + l + " " + r);
                int m = (l + r) / 2;
                // Sort the next two smaller arrays
                MergeSort(a, l, m);
                MergeSort(a, m + 1, r);
                Merge(a, l, m, r);
            }
        }

        public static void Merge(int[] a, int l, int m, int r)
        {
            Console.WriteLine("merge l m r: " + l + " " + m + " " + r);
            int n1 = m - l + 1;
            int n2 = r - m;
            int i;

            int[] L1 = new int[n1];
            int[] R1 = new int[n2];

            for (i = 0; i < n1; ++i)
            {
                L1[i] = a[+i];
            }
            for (i = 0; i < n2; ++i)
            {
                R1[i] = a[m + 1 + i];
            }

            i = 0;
            int j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L1[i] <= R1[j])
                {
                    a[k] = L1[i];
                    k++;
                    i++;
                }
                else
                {
                    a[k] = R1[j];
                    k++;
                    j++;
                }
            }

            while (i < n1)
            {
                a[k] = L1[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                a[k] = R1[j];
                j++;
                k++;
            }

        }

        public static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
