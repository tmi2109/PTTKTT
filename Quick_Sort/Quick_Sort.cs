using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    internal class Quick_Sort
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
            QuickSort(a, 0, n - 1);
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

        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int s = Partition(a, left, right);
                QuickSort(a, left, s - 1);
                QuickSort(a, s + 1, right);
            }
        }

        static int Partition(int[] a, int left, int right)
        {
            int k = (left + right) / 2;
            int x = a[k];
            int l = left;
            int r = right;

            do
            {
                while (a[l] < x) l++;
                while (a[r] > x) r--;
                if (l < r)
                {
                    Swap(ref a[l], ref a[r]);
                    l++;
                    r--;
                }
            } while (l < r);

            return r;
        }

        static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
    }
}
