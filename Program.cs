
// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// //Метод создающий массив, заполняемый случайными положительными трёхзначными числами:
// int [] RandomArray(int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// //Метод, который считает количество чётных чисел в массиве.
// void PrintEvenArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//     count++;

//     }
//     Console.WriteLine($"There are {count} even nums");
// }

// //Общий метод для двух первых задач, демонстрирующий массив в консоли:
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = RandomArray(size);
// RandomArray(size);
// PrintArray(newArray);
// PrintEvenArray(newArray);


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// //Метод создающий массив, заполняемый случайными числами:
// int [] RandomArray(int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,100);//тут для наглядности ограничил рандом двузначными числами
//     }
//     return array;
// }

// //Метод, суммирующий элементы, стоящие на нечётных позициях
// void SummOdd(int[]array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i=i+2)
//     {
//         sum = sum+array[i];
//         Console.WriteLine($"{i} index value is {array[i]}");
//     }
//     Console.WriteLine($"Summ value odd indexes is {sum}");

// }

// //Общий метод для двух первых задач, демонстрирующий массив в консоли:
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = RandomArray(size);

// PrintArray(newArray);
// SummOdd(newArray);


// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// //Метод, создающий массив с вещественными числами от 1 до 100
// double[] DoubleArray(int size)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 10000);
//         array[i] = array[i] / 100;
//     }
//     return array;
// }

// //Метод, демонстрирующий массив double в консоли:
// void PrintDouble(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// //Метод, находящий максимальное и минимальное число в массиве
// double MinMax(double[] array)
// {
// double min = array[0];
// double max = array[0];
// int i = 1;
// while (i < array.Length)
// {
// if (max<array[i])
// max = array[i];
// if (min>array[i])
// min = array[i];
// i = i + 1;
// }
// Console.WriteLine($"Minimum value is {min} and maximum value is {max}");
// return max-min;
// }

// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// DoubleArray(size);
// double[] newArray = DoubleArray(size);
// PrintDouble(newArray);
// double diff = MinMax(newArray);
// Console.WriteLine($"Difference between max and min is {diff}");