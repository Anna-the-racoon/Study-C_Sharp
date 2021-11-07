using System;
using System.Threading;
using static System.Console;

namespace MyPractice
{
    class SteppedArray
    {
        
        static void initialization(ref int rowNumber, ref int firstRow, ref int secondRow, ref int thirdRow, ref int fothRow) 
        {
            int[][] arr = new int[rowNumber][];
            arr[0] = new int[firstRow];
            arr[1] = new int[secondRow];
            arr[2] = new int[thirdRow];
            arr[3] = new int[fothRow];
            
            int number = 0;
            int size = 0;
            while (number<rowNumber)
            {
                switch (number)
                {
                    case 0:
                        size = firstRow;
                        break;
                    case 1:
                        size = secondRow;
                        break;
                    case 2:
                        size = thirdRow;
                        break;
                    case 3:
                        size = fothRow;
                        break;
                    default:
                        break;
                }
                for (int i = number, j = 0; j < size; j++)
                {
                    arr[i][j] = new Random().Next(1, 50);
                   Thread.Sleep(500);
                }
                number++;
            }
            show(arr, rowNumber, firstRow, secondRow, thirdRow, fothRow);
            WriteLine("\n\n\n");
        }

        static void show(int[][] arr, int rowNumber, int firstRow, int secondRow, int thirdRow, int fothRow)
        {
            int number = 0;
            int size = 0;

            while (number < rowNumber)
            {
                switch (number)
                {
                    case 0:
                        size = firstRow;
                        break;
                    case 1:
                        size = secondRow;
                        break;
                    case 2:
                        size = thirdRow;
                        break;
                    case 3:
                        size = fothRow;
                        break;
                    default:
                        break;
                }
                for (int i = number, j = 0; j < size; j++)
                {
                    Write($"{arr[i][j]}   ") ;
                }
                WriteLine("");
                number++;
            }
        }

        static void main(string[] args)
        {
            int a = 4, b = 4, c = 3, d = 6, e = 5;
            initialization(ref a, ref b, ref c, ref d, ref e);
            //show(a, b, c, d, e);

            // Объявляем ступенчатый массив


            //initialization and show
            int[][] arr = new int[a][]; //4
            arr[0] = new int[b]; //4
            arr[1] = new int[c];    //3
            arr[2] = new int[d]; //6
            arr[3] = new int[e];  //5


            int i = 0;

            for (int j = 0; j < arr[i].Length; j++)
            {
                Write($"{arr[i][j] = new Random().Next(1, 500)}  ");
                Thread.Sleep(800);
            }
            WriteLine("");
            i++;
            for (int j = 0; j < arr[i].Length; j++)
            {
                Write($"{arr[i][j] = new Random().Next(1, 500)}  ");
                Thread.Sleep(800);
            }
            WriteLine("");
            i++;
            for (int j = 0; j < arr[i].Length; j++)
            {
                Write($"{arr[i][j] = new Random().Next(1, 500)}  ");
                Thread.Sleep(800);
            }
            WriteLine("");
            i++;
            for (int j = 0; j < arr[i].Length; j++)
            {
                Write($"{arr[i][j] = new Random().Next(1, 500)}  ");
                Thread.Sleep(800);
            }
            WriteLine("");

            ReadLine();
        }
    }
}
