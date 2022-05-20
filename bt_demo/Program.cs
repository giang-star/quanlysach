using System;

namespace bt_demo
{
    class Program

    {
        public static void nhap(int[] a, int n
            )
        {


            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void hienthi(int[] a, int n)
        {
            Console.Write(" mang vua nhap :\n");
            for (int i = 0; i < n; i++)
                Console.Write("{0}\t ", a[i]);
        }
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Console.WriteLine("Nhap so phan tu trong mang : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Program.nhap(a, n);
            Program.hienthi(a, n);
            Console.ReadKey();
        }
    }
}
