using System;
using static System.Console;

namespace MyPractice
{
    class ClassArray
    {
        static void main(string[] args)
        {
            Array arr = Array.CreateInstance(typeof(int), 10);
            //initialization for object from class Array
            var random = new Random().Next(100);

            for (int i = 0; i < 10; i++)
            {
                arr.SetValue(i, i);
                //Thread.Sleep(500); 
            }
            
            //Debug.Print("Hello ");

            foreach (var i in arr)
            {
                Write($"{i}  ");
            }
            WriteLine();

            /*WriteLine($"Имеет ли массив фиксированный размер = { arr.IsFixedSize}");
            WriteLine($"Доступен ли массив только для чтения = { arr.IsReadOnly}");
            WriteLine($"Имеет ли массив асинхронизированный доступ  = { arr.IsSynchronized}");
            WriteLine($"Общее число элементов массива = { arr.Length}");
            WriteLine($"Показывает количество строк в массиве = { arr.Rank}");
            WriteLine($"Возвращает элемент который можно использовать для синхронизации доступа = { arr.SyncRoot}");
            WriteLine();*/

            /*IReadOnlyCollection<int> arrList = Array.AsReadOnly((int[])arr);
            foreach (var i in arr)
            {
                Write($"{i}  ");
            }
            WriteLine();*/

            //WriteLine($"ВЫполняется поиск заданного '5' элемента и указывается его место в массиве = {Array.BinarySearch(arr, 5)}");

            //очищает все элементы в выбранном диапазоне
            /*Array.Clear(arr, 2, 5);
            foreach (var i in arr)
            {
                Write($"{i}  ");
            }
            WriteLine();*/

            //clone
            /*var cloneArrey = (int[])arr.Clone();
            WriteLine("На экране отобразится клон нашего массива:");
            foreach (var j in cloneArrey)
            {
                Write($"{j}  ");
            }
            WriteLine();*/

            //copy part of elements
            /*WriteLine("Копирует часть выбранных элементов:");
            Array.ConstrainedCopy(arr, 6, cloneArrey, 2, 3);
            foreach (var j in cloneArrey)
            {
                Write($"{j}  ");
            
            WriteLine();*/

            /*var test = Array.Empty<int>();

            test = new int[5];

            test.SetValue(5, 0);
            test.SetValue(4, 1);

            test = new int[8]; // происходит перезапись предыдущего саммива

            foreach (var i in test)
            {
                Write($"{i}  ");
            }
            WriteLine();*/

            /*var equally = Array.Equals(arr, arr);
            WriteLine($"Данная функция покажет равны ли между собой две сравниваемые матрицы - {equally}");
            WriteLine();*/

            /*Fill<int>(arr, 8);
            foreach (var i in arr)
            {
                Write($"{i}  ");
            }
            WriteLine();*/

            //Array.Find<int>(arr, 5);


            /*var mySegmentsArray = new ArraySegment<int>((int[])arr, 2, 4);
            foreach (var i in mySegmentsArray)
            {
                Write($"{i}  ");
            }
            WriteLine();*/


            ReadLine();
        }

    }
}

