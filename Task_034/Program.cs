// Task_034
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   array[i] = new Random().Next(100, 1000);
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
InputArray(array);
Console.WriteLine("Массив: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

int count = 0;
for (int z = 0; z < array.Length; z++)
   if (array[z] % 2 == 0)
       count++;

Console.WriteLine($"Всего чисел: {array.Length}, из них четных: {count}");

