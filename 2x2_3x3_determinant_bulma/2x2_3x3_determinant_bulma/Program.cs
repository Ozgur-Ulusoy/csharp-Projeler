using System;

namespace _2x2_3x3_determinant_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@" Determinant Hesaplama Makinesine Hoşgeldiniz");

            int determinant;
            Console.WriteLine("Matris Satırını Giriniz");
            int satır = int.Parse(Console.ReadLine());
            Console.WriteLine("Matris Sütununu Giriniz");
            int sutun = int.Parse(Console.ReadLine());
            int[,] matris = new int[satır, sutun];

            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.WriteLine("{0} {1} Elemanı Giriniz", i, j);
                    int eleman = Convert.ToInt32(Console.ReadLine());
                    matris[i, j] = eleman;

                }
            }
            Console.WriteLine(" ");

            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(matris[i, j] + "  ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");

            if (satır == 2 && sutun == 2)
            {
                Console.WriteLine("Determinant");
                int a = matris[0, 0]; int b = matris[0, 1]; int d = matris[1, 0]; int e = matris[1, 1];
                determinant = (a * e - b * d);
                Console.WriteLine(determinant);

            }

            if (satır == 3 && sutun == 3)
            {
                Console.WriteLine("Determinant ");
                int a = matris[0, 0]; int b = matris[0, 1]; int c = matris[0, 2]; int d = matris[1, 0]; int e = matris[1, 1]; int f = matris[1, 2]; int g = matris[2, 0]; int h = matris[2, 1]; int i = matris[2, 2];
                determinant = (a * e * i + d * h * c + g * b * f) - (c * e * g + f * h * a + i * b * d);
                Console.WriteLine(determinant);

                if (determinant == 0)
                {
                    Console.WriteLine("Lineer Bağımlı");
                }

                else
                {
                    Console.WriteLine("Lineer Bağımsız ve Uzayı Gerer");
                }
            }
        }
    }
}
