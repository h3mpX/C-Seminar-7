
Console.WriteLine("Задайте двумерный массив размером m / n, заполненный случайными вещественными числами.");
Console.WriteLine();
Console.WriteLine("Для продолжения нажмите Enter...");
Console.ReadLine();

double[,] CreateRandom2dDoubleArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 9) + new Random().NextDouble();


    return array;
}

void Show2dDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] newArray = CreateRandom2dDoubleArray(rows, columns);

Show2dDoubleArray(newArray);



Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,"
                + "и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine();
Console.WriteLine("Для продолжения нажмите Enter...");
Console.ReadLine();


int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[10, 10];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(10, 99 + 1);


    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j]) + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void CheckExistPosition(int[,] array, int rows, int columns) /// почему нельзя сделать через bool метод? Ругается, что не все пути к коду возвращают значение. 
{                                                            /// было бы удобно, метод бы был однострочным и в основной программе мы бы делали проверку на тру-фолс 
    if (rows > array.GetLength(0) || columns > array.GetLength(1))
        Console.WriteLine("Такой позиции не существует");
    else Console.WriteLine($"Значение элемента: " + array[rows, columns]);
}

int[,] newArray2 = CreateRandom2dArray(10, 10);
Show2dArray(newArray2);  ///чтобы было видно, совпадает ли элемент с вызываемым
Console.Write("Введите строку: ");
rows = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
columns = Convert.ToInt32(Console.ReadLine()) - 1;
CheckExistPosition(newArray2, rows, columns);




Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();
Console.WriteLine("Для продолжения нажмите Enter...");
Console.ReadLine();

double[] GetAverageFromColumns(int[,] array)
{
    double[] average = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j]; 
        average[j] = sum / array.GetLength(0);
    }
    return average;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            Console.Write((array[i]) + "\t");
    }
    Console.WriteLine();
}


int[,] newArray3 = CreateRandom2dArray(10, 10);
Show2dArray(newArray3);
double[] resultArray = GetAverageFromColumns(newArray3);
ShowDoubleArray(resultArray);