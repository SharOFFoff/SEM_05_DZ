// Task_038
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] PrintArray (int size, int min, int max)
{
    double[] array = new double [size];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}


double DiffMaxMin ( double[] array)
{
    double max = array[0];
        for (int i = 0; i< array.Length-1; i++)
    {
        if (max < array[i+1])
        max = array[i+1];
    }

    double min = array[0];
        for (int i = 0; i< array.Length-1; i++)
        {
            if (min > array[i+1])
            min = array [i+1];
        }

    double diff = max - min;
    return diff;
}

Console.Clear();
 double[] matrix = PrintArray(10, -100, 100);
 Console.WriteLine($"[{String.Join(", ", matrix)}] -> {DiffMaxMin(matrix)}");
