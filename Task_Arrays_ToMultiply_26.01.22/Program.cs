using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2Dim_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Задана целочисленная матрица M[m][n].
            // Элементы этой матрицы, без остатка делящиеся на 6, переписать в массив L[] и найти их произведение. 
            // Напечатать матрицу M, массив L и найденное произведение. Числа m и n вводятся с клавиатуры.


            Console.WriteLine("Введите длину ряда матрицы");             // Получаем число М (длина ряда / количество столбцов).
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину столбца матрицы");          // Получаем число N (длина столбца / количество рядов).
            var n = int.Parse(Console.ReadLine());


            var arrayM = ArrayHandler.GetNewArray(m, n);                 // Создаем двухмерный массив М заданных нами размеров.   
            ArrayHandler.ToPrintArray(arrayM);                           // Выводим его

            var arrayL = ArrayHandler.GetOnlyDividingBySix(arrayM);      // Создаем список, из значений массива М, которые делятся на 6 без остатка.  
            ArrayHandler.ToPrintArray(arrayL);                           // Выводим его

            var MultiplyResult = ArrayHandler.ToMultiplyAll(arrayL);     // Перемножаем все значения списка. 
            Console.WriteLine($"\n\n\tРезультат умножения всех значений массива L: {MultiplyResult}");


            Console.ReadLine();


        }
    }
}
