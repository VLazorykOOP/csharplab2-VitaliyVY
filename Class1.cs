using System;
using System.Linq;

namespace ConsoleApplication
{
    class Class1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Задача 1");
                Console.WriteLine("2. Задача 2");
                Console.WriteLine("3. Задача 3");
                Console.WriteLine("4. Задача 4");
                Console.WriteLine("5. Вийти");
                Console.Write("Виберіть опцію: ");

                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Некоректний ввід. Будь ласка, введіть число від 1 до 5.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Невідома опція. Будь ласка, введіть число від 1 до 5.");
                        break;
                }
            }
        }

        static void Task1()
        {
            Console.Write("Введіть розмірність масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < number)
                    array[i] *= 2;
            }

            Console.WriteLine("Результат:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Task2()
        {
            Console.Write("Введіть розмірність масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxIndex = 0;
            int maxValue = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            int temp = array[maxIndex];
            array[maxIndex] = array[0];
            array[0] = temp;

            Console.WriteLine("Результат:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Task3()
        {
            Console.Write("Введіть розмірність масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];

            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j > n - 1)
                    {
                        sum += array[i, j];
                        count++;
                    }
                }
            }

            double average = (double)sum / count;
            Console.WriteLine($"Середнє арифметичне елементів під побічною діагоналлю: {average}");
        }

        static void Task4()
        {
            Console.Write("Введіть кількість рядків: ");
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
                int m = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[m];

                Console.WriteLine($"Введіть елементи для рядку {i + 1}:");
                for (int j = 0; j < m; j++)
                {
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            int maxColumns = jaggedArray.Max(row => row.Length);
            int[] sums = new int[maxColumns];

            for (int j = 0; j < maxColumns; j++)
            {
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    if (j < jaggedArray[i].Length && jaggedArray[i][j] > 0 && jaggedArray[i][j] % 2 == 0)
                    {
                        sums[j] += jaggedArray[i][j];
                    }
                }
            }

            Console.WriteLine("Суми парних додатних елементів для кожного стовпця:");
            for (int i = 0; i < maxColumns; i++)
            {
                Console.WriteLine($"Стовпець {i + 1}: {sums[i]}");
            }
        }
    }
}

