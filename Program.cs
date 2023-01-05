using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr9
{
    class myArray

    {

        public int[,] intArray;

        public myArray(int n, int m)

        {

            this.intArray = new int[n, m];

        }

        //Количество нулей

        public int amountOFNull

        {

            get

            {

                int res = 0;

                for (int i = 0; i <= this.intArray.GetLength(0) - 1; i++)

                {

                    for (int j = 0; j <= this.intArray.GetLength(1) - 1; j++)

                    {

                        if (this.intArray[i, j] == 0)

                        {

                            res++;

                        }

                    }

                }

                return res;

            }

            private set

            {

            }

        }

        public int setScalar

        {

            set

            {

                for (int i = 0; i <= this.intArray.GetLength(0); i++)

                {

                    for (int j = 0; j <= this.intArray.GetLength(1); j++)

                    {

                        if (i == j)

                        {

                            this.intArray[i, j] = value;

                        }

                    }

                }

            }

        }

        //Заполнить массив

        public void fillArray()

        {

            for (int i = 0; i <= this.intArray.GetLength(0) - 1; i++)

            {

                for (int j = 0; j <= this.intArray.GetLength(1) - 1; j++)

                {

                    Console.Write($"[{i + 1}, {j + 1}] = ");

                    this.intArray[i, j] = int.Parse(Console.ReadLine());

                }

            }

        }

        //Случайно заполнить массив

        public void randomFillArray(int minNum, int maxNum)

        {

            Random rnd = new Random();

            for (int i = 0; i <= this.intArray.GetLength(0) - 1; i++)

            {

                for (int j = 0; j <= this.intArray.GetLength(1) - 1; j++)

                {

                    this.intArray[i, j] = rnd.Next(minNum, maxNum);

                }

            }

        }

        //Вывод массива

        public void showArray()

        {

            Console.WriteLine("Вывод массива");

            for (int i = 0; i <= this.intArray.GetLength(0) - 1; i++)

            {

                for (int j = 0; j <= this.intArray.GetLength(1) - 1; j++)

                {

                    Console.Write($"{this.intArray[i, j]}\t");

                }

                Console.WriteLine();

            }

        }

        //Сумма в колонке

        public int getSumOfCol(int col)

        {

            int res = 0;

            for (int i = 0; i <= this.intArray.GetLength(0) - 1; i++)

            {

                res += this.intArray[i, col];

            }

            return res;

        }

        //Индексатор

        public int this[int i, int j]
        {

            get

            {

                return intArray[i, j];

            }

            set

            {

                intArray[i, j] = value;

            }

        }

        //Оператор ++

        public static myArray operator ++(myArray arr)

        {

            for (int i = 0; i <= arr.intArray.GetLength(0) - 1; i++)

            {

                for (int j = 0; j <= arr.intArray.GetLength(1) - 1; j++)

                {

                    arr.intArray[i, j] += 1;

                }

            }

            return arr;

        }

        //Оператор --

        public static myArray operator --(myArray arr)

        {

            for (int i = 0; i <= arr.intArray.GetLength(0) - 1; i++)

            {

                for (int j = 0; j <= arr.intArray.GetLength(1) - 1; j++)

                {

                    arr.intArray[i, j] -= 1;

                }

            }

            return arr;

        }

        //Бинарный +

        public static myArray operator +(myArray arr1, myArray arr2)

        {

            myArray resArr = new myArray(arr1.intArray.GetLength(0), arr1.intArray.GetLength(1));

            if ((arr1.intArray.GetLength(0) == arr2.intArray.GetLength(0)) && (arr1.intArray.GetLength(1) == arr2.intArray.GetLength(1)))

            {

                for (int i = 0; i <= arr1.intArray.GetLength(0) - 1; i++)

                {

                    for (int j = 0; j <= arr1.intArray.GetLength(1) - 1; j++)

                    {

                        resArr.intArray[i, j] = arr1.intArray[i, j] + arr2.intArray[i, j];

                    }

                }

            }

            else

            {

                Console.WriteLine("Матрицы разных размеров");

            }

            return resArr;

        }

        //Приведение типа к логическому

        public static implicit operator bool(myArray arr)

        {

            if (arr.intArray.GetLength(0) == arr.intArray.GetLength(1))

            {

                return true;

            }

            return false;

        }

        //Преобразование массива в класс

        public static implicit operator myArray(int[,] arr)

        {

            myArray resArr = new myArray(arr.GetLength(0), arr.GetLength(1));

            for (int i = 0; i <= arr.GetLength(0); i++)

            {

                for (int j = 0; j <= arr.GetLength(1); j++)

                {

                    resArr.intArray[i, j] = arr[i, j];

                }

            }

            return resArr;

        }

        //Преобразование класса в массив

        public static implicit operator int[,](myArray obj)

        {

            int[,] resArr = new int[obj.intArray.GetLength(0), obj.intArray.GetLength(1)];

            for (int i = 0; i <= obj.intArray.GetLength(0); i++)

            {

                for (int j = 0; j <= obj.intArray.GetLength(1); j++)

                {

                    resArr[i, j] = obj.intArray[i, j];

                }

            }

            return resArr;

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Певый массив

            Console.Write("Введите кол-во строк в массиве: ");

            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Введите кол-во столбцов в массиве: ");

            int m1 = int.Parse(Console.ReadLine());

            var a = new myArray(n1, m1);

            a.fillArray();

            a.showArray();

            Console.WriteLine($"{a.getSumOfCol(1)}");

            Console.WriteLine(a.amountOFNull);

            a++;

            a.showArray();

            //Индексация

            Console.Write("Введите индекс строки для поиска элемента: ");

            int arrRow = int.Parse(Console.ReadLine());

            Console.Write("Введите индекс стобца для поиска элемента: ");

            int arrCol = int.Parse(Console.ReadLine());

            Console.WriteLine($"Элемент: {a[arrRow, arrCol]}");

            if (a)

            {

                Console.WriteLine("Массив квадратный");

            }

            else

            {

                Console.WriteLine("Массив не квадратный");

            }

            //Второй массив

            Console.Write("Введите кол-во строк в массиве: ");

            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Введите кол-во столбцов в массиве: ");

            int m2 = int.Parse(Console.ReadLine());

            myArray b = new myArray(n2, m2);

            b.randomFillArray(0, 20);

            b.showArray();

            myArray c = a + b;

            c.showArray();
        }
    }
}
