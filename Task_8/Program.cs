// See https://aka.ms/new-console-template for more information
int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("  ");
    Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.WriteLine("Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).");
    Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
    programm = Convert.ToInt32(Console.ReadLine());
    switch(programm)
    {
        case 1:
        //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            Console.WriteLine("Введите высоту двумерного массива: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину двумерного массива: ");
            int lenght = int.Parse(Console.ReadLine());
            int[,] array = new int[height,lenght];
            FunctionRandomArray(array);
            //Создание массива с рандомными числами
            void FunctionRandomArray(int[,] arr)
            {

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for(int j = 0; j < arr.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                        Console.Write(array[i,j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("---------");
            }

            //Сортировка массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                   for(int g = 0; g < array.GetLength(1) - 1; g++)
                   {
                        if (array[i, g] < array[i, g + 1])
                        {
                            int temp = array[i, g + 1];
                            array[i, g + 1] = array[i, g];
                            array[i, g] = temp;
                        }
                   }
                }
            }
            //Вывод массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

        break;
        case 2:
        //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            Console.WriteLine("Введите высоту двумерного массива: ");
            int height1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину двумерного массива: ");
            int lenght1 = int.Parse(Console.ReadLine());
            int[,] array1 = new int[height1,lenght1];
            FunctionRandomArray1(array1);
            WriteArray(array1);
            //Задаем массив с рандомными значениями
            void FunctionRandomArray1(int[,] arr)
            {

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for(int j = 0; j < arr.GetLength(1); j++)
                    {
                        array1[i, j] = new Random().Next(1, 10);
                       
                    }
                }
            }
            int minSumLine = 0;
            int sumLine = SumLineElements(array1, 0);
            for (int i = 1; i < array1.GetLength(0); i++)
            {
                int tempSumLine = SumLineElements(array1, i);
                if (sumLine > tempSumLine)
                {
                    sumLine = tempSumLine;
                    minSumLine = i;
                }
            }

            Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

            //Считаем сумму строки
            int SumLineElements(int[,] array, int i)
            {
                int sumLine = array[i,0];
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    sumLine += array[i,j];
                }
                return sumLine;
            }
            void WriteArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        break;
        case 3:
        //Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
            //Данные вводимые пользователем
            int  first_height2 = InputParametr("Введите высоту первого массива: ");
            int  first_and_second_lenght2 = InputParametr("Введите длину первого и второго массива: ");
            int  second_height3 = InputParametr("Введите высоту второго массива: ");
            //МАтрицa перввая 
            int[,] firstMartrix = new int[first_height2, first_and_second_lenght2];
            FunctionRandomArray2(firstMartrix);
            Console.WriteLine("Первая матрица");
            WriteArray(firstMartrix);
            //Матрица вторая
            int[,] secomdMartrix = new int[second_height3, first_and_second_lenght2];
            FunctionRandomArray2(secomdMartrix);
            Console.WriteLine("Вторая матрица");
            WriteArray(secomdMartrix);
            //Произведение двух матриц
            int[,] resultMatrix = new int[first_height2, first_and_second_lenght2];
            MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
            Console.WriteLine($"Произведение первой и второй матриц:");
            WriteArray(resultMatrix);
            //Ввод данныйх
            int InputParametr(string message)
            {
                Console.WriteLine(message);
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            //Нахождение произведения двух матриц
            void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
            {
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < firstMartrix.GetLength(1); k++)
                        {
                            sum += firstMartrix[i,k] * secomdMartrix[k,j];
                        }
                        resultMatrix[i,j] = sum;
                    }
                }
            }
            //Рандомные значения
            void FunctionRandomArray2(int[,] arr)
            {

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for(int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = new Random().Next(0, 10);
                       
                    }
                }
            }
            //Вывод матриц
            void WriteArray1(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                    Console.Write(array[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
    
    
        break;
        case 4:
        //Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        int[,,] array3D = new int[2, 2, 2];
        FillArray(array3D);
        PrintIndex(array3D);


        // Функция вывода индекса элементов 3D массива
        void PrintIndex(int[,,] arr)
        {
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
                    }
                }
             }
        }

        // Функция заполнения 3D массива не повторяющимеся числами
        void FillArray(int[,,] arr)
        {
            int count = 10;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[k, i, j] += count;
                        count += 3;
                    }   
                }
            }
        }
        break;
    default:
             begin = false;
             break;
}
}

