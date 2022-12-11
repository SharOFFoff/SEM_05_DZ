// Task_036
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   array[i] = new Random().Next(-1000, 1000);
}

void ReleaseArray(int[] array)
{
   int sum = 0;
   for (int i = 1; i < array.Length; i += 2)
   {
       sum += array[i];
   }
   Console.WriteLine($"Сумма чисел на нечетных позициях: {sum}");
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
InputArray(array);
Console.WriteLine("Массив: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
