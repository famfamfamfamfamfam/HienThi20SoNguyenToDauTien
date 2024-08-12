using System;

namespace SUDUNGCAULENHLAP
{
    class HienThi20SoNguyenToDauTien
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int count = 0;
            int n = 2;
            while (count < numbers)
            {
                int divisorcount = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        divisorcount++;
                    }
                }
                if (divisorcount == 2)
                {
                    Console.WriteLine(n);
                    count++;
                }
                n++;
            }

        }
    }
}