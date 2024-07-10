﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTong
{
    internal class TinhTong
    {
        const int MAX = 100;

        static void Main()
        {
            int[] a = new int[MAX];
            int n;

            do
            {
                Console.Write("Nhap phan tu cua mang: ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > MAX);

            NhapMang(a, ref n);
            Console.WriteLine("Mang chua duoc sap xep:");
            XuatMang(a, n);

            int ketqua = Sum(a, 0, n - 1);
            Console.WriteLine($"\nKet qua: {ketqua}");
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

        static int Sum(int[] a, int l, int r)
        {
            if (l == r)
                return a[l];

            int mid = (l + r) / 2;
            int temp1 = Sum(a, l, mid);
            int temp2 = Sum(a, mid + 1, r);
            return temp1 + temp2;
        }
    }
}
