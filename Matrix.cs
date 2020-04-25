using System;

namespace MatrixClass
{
    class Matrix
    {
        public int stroka, stolbec;
        public int[,] matrix = new int[stroka, stolbec];
        public Matrix(){}
        public Matrix(int str)
        {
            this.stroka = str;
        }
        public Matrix(int str, int sto)
        {
          this.stroka = str;
          this.stolbec = sto;
        }
        public int Ret(int i, int j)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Вывод выборочного элемента массива: ")
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("i = ");
            Console.ForegroundColor = ConsoleColor.White;
            i = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("j = ");
            Console.ForegroundColor = ConsoleColor.White;
            j = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            return matrix[i,j];
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void ZapolGenerCh(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Заполнение матрицы случайными числами: ");
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Укажите диапозон своих случайных чисел, которыми заполнится ваш массив: ");
            Console.Write("Начальный диапозон: ");
            Console.ForegroundColor = ConsoleColor.White;
            a = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Конечный диапозон: ");
            Console.ForegroundColor = ConsoleColor.White;
            b = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<stroka; i++)
            {
                for (int j=0; j<stolbec; j++)
                {
                    matrix[i,j] = rnd.Next(a, b);
                }
            }
        }
        public void Zapol()
        {
            Console.ForegroundColor = ConsoleColor.Magente;
            Console.WriteLine("Заполнение матрицы своими значениями: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i=0; i<stroka; i++)
            {
                for (int j=0; j<stolbec; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"a[{i},{j}] = "); 
                    Console.ForegroundColor = ConsoleColor.White;
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }
        }
        public void Vivod()
        {
            Console.ForegroundColor = ConsoleColor.Magente;
            Console.WriteLine("Вывод массива: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i=0; i<stroka; i++)
            {
                for (int j=0; j<stolbec; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}