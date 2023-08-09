internal class Program
{
    private static void Main(string[] args)
    {
        void FillArrayDouble(double[,] matrix, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
                    matrix[i, j] = Math.Round(matrix[i, j], 2);
                }
            }
        }
        
        void FillArray(int[,] matrix, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random random = new Random();      
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int  j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue);
                }
            }
        }
        void PrintArrayDouble(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                    for (int  j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
            }  
        }
        void PrintArray(int[,] matrix)
        {
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int  j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }  
        }
        
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        void Task47()
        {
            // Задача 47. Задайте двумерный массив размером m×n, заполненный
            // случайными вещественными числами.

            int rows = 5;
            int columns = 6;
            double[,] numbers = new double[rows, columns];

            
            FillArrayDouble(numbers, -100, 100);
            PrintArrayDouble(numbers);
        }
        // Console.Clear();
        // Task47();

        void Task50()
        {

            // Задача 50. Напишите программу, которая на вход принимает
        // позиции элемента в двумерном массиве, и возвращает значение
        // этого элемента или же указание, что такого элемента нет.


        int rows = 5;
        int columns = 6;
        int[,] numbers = new int[rows, columns];

        FillArray(numbers, -100, 100);
        PrintArray(numbers);

        int inputRow = Input("Введите строку элемента: ") - 1;
        int inputColumn = Input("Введите столбец элемента: ") - 1;

        if (inputRow >= 0 && inputRow < rows &&
            inputColumn >= 0 && inputColumn < columns)
            {
                Console.WriteLine($"Ваш элемент: {numbers[inputRow, inputColumn]}");
            }
            else
            {
                Console.WriteLine($"Некорректный ввод");
            }

        }
        // Console.Clear();
        // Task50();


        void Task52()
        {
            //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

        int rows = 5;
        int columns = 6;
        int[,] numbers = new int[rows, columns];

        FillArray(numbers, 0, 9);
        PrintArray(numbers);
        Console.WriteLine();

        for (int j = 0; j < columns; j++)
        {
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += numbers[i, j];
            }
            double result = sum/rows;
            result = Math.Round(result, 2);
            Console.Write($"{result}\t");
        }
        }
        Console.Clear();
        Task52();

        


        

        
    }
            
}