using System;
using static System.Console;

namespace MyPractice
{
    class ClassRandom
    {
        //make my own Random class
        private class BooleanGeneration
        {
            public bool NextBoolean(Random rand)
            {
                return Convert.ToBoolean(rand.Next(0, 2));
            }

    }

        static void main(string[] args)
        {

            var rand = new Random(); //dependency from time
            Random ranndomize = new Random(5); // dependency from Int32. every time work with the same numbers

            WriteLine("Сейчас будет проходить заполнение случайными числами разного типа некоторого количества элементов.\nСлучайными байтами:");
            //generate and show 5 random byte value
            var bytes = new byte[5];
            rand.NextBytes(bytes);
            foreach (byte byteValue in bytes)
            {
                Write("{0, 8}   ", byteValue);
            }

            WriteLine("\nСлучайными целыми числами:");

            //generate and show 5 random Int32 value
            for (int ctr = 0; ctr <= 4; ctr++)
            {
                Write("{0,10:N0}", rand.Next(1, 50));
            }

            WriteLine("\nСлучайными числами с плавающей точкой:");

            //generate and show 5 random Double value
            for (int ctr = 0; ctr <= 4; ctr++)
            {
                Write("{0,10:N3}", rand.NextDouble());
            }

            WriteLine("\nСлучайными числами с плавающей точкой в диапазоне от -1 до 0:");

            //generate and show 5 random Double value
            for (int ctr = 0; ctr <= 4; ctr++)
            {
                Write("{0,10:N3}", rand.NextDouble()-1);
            }

            WriteLine("\nСлучайными числами с плавающей точкой  начиная от 0 в заданном диапазоне:");

            //generate and show 5 random Double value
            for (int ctr = 0; ctr <= 4; ctr++)
            {
                Write("{0,10:N3}", rand.NextDouble() * 50);
            }

            WriteLine("\nСлучайными числами с плавающей точкой в заданном диапазоне:");

            //generate and show 5 random Double value
            for (int ctr = 0; ctr <= 4; ctr++)
            {
                Write("{0,10:N3}", rand.NextDouble() * (50 -(-50))+-50);
            }


            WriteLine("\n\n");

            //Mix sort
            WriteLine("Сейчас будет проходить сортировка массива случайными значениями");
            int[] arrey = {0,1,2,3,4,5,6,7,8,9};

            foreach (var show in arrey)
            {
                Write($"{show}   ");
            }
            WriteLine("\n\n");


            //recomendation to make changes till number of changes shoult be half of numder of all elements in arrey
            for (int change = 0; change < 5; change++)
            {
                for (int i = 0; i < 10; i++)
                {
                    var temp = arrey[i]; //передаем текущее значение во временную переменную
                    var iRand = rand.Next(0, 10); // присваем случайное значение переменной, которую будем использовать в качестве нового значения индекса
                    arrey[i] = arrey[iRand]; // присваиваем значение на новое место 
                    arrey[iRand] = temp; // присваиваем значение исходного значения на новое место
                }
                // show to console each change of the arrey
                foreach (var show in arrey)
                {
                    Write($"{show}   ");
                }
                WriteLine("\n\n");
            }

            //work with BooleanGeneration
            var itemForBool = new BooleanGeneration().NextBoolean(rand);
            WriteLine($"сейчас проведем игру по принципу \"ромашки\"\n{(itemForBool == true ? "любит" : "не любит" )}");


            ReadLine();
        }
    }
}

