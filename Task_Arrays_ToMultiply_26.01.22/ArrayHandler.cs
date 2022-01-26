using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2Dim_Array
{
    public class ArrayHandler
    {

        public static int[,] GetNewArray(int rowLenght, int columnLenght)  // Метод создающий новый массив по заданным параметрам.
        {


            int[,] newArray = new int[rowLenght, columnLenght]; // Создаем новый массив с заданным количеством рядов и столбцов.
            var rnd = new Random();

            var i = 0;
            while (i < rowLenght)
            {
                var j = 0;
                while (j < columnLenght)
                {
                    newArray[i, j] = rnd.Next(0, 36);
                    j++;
                }
                i++;
            }

            return newArray;
        }


        public static List<int> GetOnlyDividingBySix(int[,] array) // Возвращает список чисел которые без остатка делятся на 6.                                                               
        {
            int rowLenght = array.GetLength(0);
            int columnLenght = array.GetLength(1);

            List<int> newArray = new List<int>(); // Создаем список в который будем записывать подходящие значения.

            var i = 0;
            while (i < columnLenght)
            {

                var j = 0;
                while (j < rowLenght)
                {
                    if (array[j, i] > 0 && (array[j, i] % 6) == 0) // Если число больше 0 и делится без остатка на 6 - добавляем.
                    {
                        newArray.Add(array[j, i]);

                    }
                    j++;
                }

                i++;
            }
            return newArray;
        }


        public static long ToMultiplyAll(List<int> array) // Перемножаем все значения в списке. 
        {
            long result = 1;
            var i = 0;

            while (i < array.Count)
            {
                result *= array[i];
                i++;
            }

            return result;
        }



        public static void ToPrintArray(int[,] array)  // Перегрузка - Выводим переданный двухмерный массив на консоль.
        {
            int rowLenght = array.GetLength(0);
            int columnLenght = array.GetLength(1);

            Console.Write("\n\tВаш двухмерный массив M:\n");

            var i = 0;
            while (i < columnLenght)
            {
                var j = 0;
                while (j < rowLenght)
                {
                    Console.Write("\t" + array[j, i]);
                    j++;
                }
                Console.Write("\n");
                i++;
            }

        }

        public static void ToPrintArray(int[] array)  // Перегрузка - Выводим переданный одномерный массив на консоль.
        {
            Console.Write("\n\tВаш одномерный массив L:\n");

            var i = 0;
            while (i < array.Length)
            {
                Console.Write("\t" + array[i]);
                i++;
            }

        }


        public static void ToPrintArray(List<int> array)  // Перегрузка - Выводим переданный список на консоль.
        {
            Console.Write("\n\tВаш одномерный массив L:\n");

            var i = 0;
            while (i < array.Count)
            {
                Console.Write("\t" + array[i]);
                i++;
            }

        }

    }



}
