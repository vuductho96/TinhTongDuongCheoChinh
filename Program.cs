using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Moi nhap so hang va so cot cua ma tran: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++) // nhập thong tin
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Nhap gia tri cua phan tu [{0}, {1}]:", i, j);
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine("Tong cac phan tu tren duong cheo chinh cua ma tran la: " + sum);
        Console.ReadLine();
    }
}
