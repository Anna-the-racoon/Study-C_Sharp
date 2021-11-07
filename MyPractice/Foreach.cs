using System;
using static System.Console;

namespace MyPractice
{
    class Foreach
    {
        static void main(string[] args)
        {
            //for  one-demention arrey 
            int[] arrey = new int[10];
            foreach (var i in arrey)
            {
                Write($"{arrey[i] = new Random().Next(50)} "); // show + random initialization 
            }

            WriteLine($"\n\n");

            //for many-dementions arrey
            //не подходит для инициализации многомерных массивов 
            int[,] secondArrey = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Write($"{secondArrey[i, j] = new Random().Next(1, 100)}   ");
                }
                 WriteLine("");
            }
            WriteLine("");
            //можно использовать для печати, но невозможно разобрать где тут какой ряд заканчивается и где начинается новый
            foreach (var i in secondArrey)
            {
                Write($"{i}  ");
            }
            WriteLine("");
            //summ of the all elements in many-demention arrey
            int summ = 0;
            foreach (var i in secondArrey)
            {
                summ += i;
            }
            WriteLine($"Сумма всех элементов массива составляет - {summ}.");

            //если ее не использовать, то консоль будет моментально закрываться после выполнения программы
            ReadLine();
        }
    }
}
