using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    internal class Merge_Sort
    {
        const int MAX = 100;

        static void Main()
        {
            int[] a = new int[MAX];
            int n;

            do
            {
                Console.Write("Nhap phan tu cua mang: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > MAX);

            NhapMang(a, ref n);
            Console.WriteLine("Mang chua duoc sap xep:");
            XuatMang(a, n);
            MergeSort(a, 0, n - 1);
            Console.WriteLine("\nMang sau khi duoc sap xep:");
            XuatMang(a, n);
        }

        static void NhapMang(int[] a, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {
                    Console.Write($"Nhap phan tu a[{i}]: ");
                }
            }
        }

        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{a[i]}");
            }
            Console.WriteLine();
        }

        static void Merge(int[] a, int l, int m, int r)
        {
            int[] b = new int[r - l + 1];
            int i = l, j = m + 1, k = 0;

            while (i <= m && j <= r)
            {
                if (a[i] <= a[j])
                {
                    b[k++] = a[i++];
                }
                else
                {
                    b[k++] = a[j++];
                }
            }

            while (i <= m)
            {
                b[k++] = a[i++];
            }

            while (j <= r)
            {
                b[k++] = a[j++];
            }

            for (k = 0; k < b.Length; k++)
            {
                a[l + k] = b[k];
            }
        }

        static void MergeSort(int[] a, int l, int r)
        {
            if (l >= r) return;

            int mid = (l + r) / 2;
            MergeSort(a, l, mid);
            MergeSort(a, mid + 1, r);
            Merge(a, l, mid, r);
        }
    }
}
