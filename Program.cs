/*Задача 1: Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.*/


// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void SearchValueByIndex(int[,] matrix)
// {
//     Console.Write("Введите индекс строки: ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите индекс столбца: ");
//     int col = Convert.ToInt32(Console.ReadLine());
//     if (row <= matrix.GetLength(0) && col <= matrix.GetLength(0))
//     {
//         int value = matrix[row, col];
//         Console.WriteLine($"Значение элемента с индексом {row},{col}: {value}");
//     }
//     Console.WriteLine($"Такого элемента нет :( ");
//     return;
// }
// int[,] res = CreateMatrix(3, 3, 0, 10);
// PrintMatrix(res);
// SearchValueByIndex(res);


/*Задача 2: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива. */

// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ReplaseMatrixRows(int[,] matrix)
// {
//     int countRow = matrix.GetLength(0);
//     int countColumn = matrix.GetLength(1);
//     for (var j = 0; j < matrix.GetLength(1); j++)
//     {
//         int value = matrix[countRow - 1, j];
//         matrix[countRow - 1, j] = matrix[0, j];
//         matrix[0, j] = value;
//     }
//     return matrix;
// }
// int[,] res = CreateMatrix(3, 3, 0, 10);
// PrintMatrix(res);
// Console.WriteLine("Результат замены: ");
// ReplaseMatrixRows(res);
// PrintMatrix(res);


/*Задача 3: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/


// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void FindString(int[,] matrix)
// {
//     int[] rowArray = new int[matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum = matrix[i, j];
//         }
//         rowArray[i] = sum;
//     }
//     int minRow = rowArray[0];
//     int numberMinRow = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (minRow > rowArray[i])
//         {
//             minRow = rowArray[i];
//             numberMinRow = i;
//         }
//     }
//     Console.WriteLine($"Наименьшую сумму элементов имеет строка с индексом: {numberMinRow}");
//     return;
// }
// int[,] res = CreateMatrix(2, 3, 0, 5);
// PrintMatrix(res);
// FindString(res);



