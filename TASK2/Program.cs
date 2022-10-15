// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void Main()
{
    Console.Clear();
    int SIZE, max, min;
    ReceiveSizeAndRangeOfArray(out SIZE, out max, out min );
    int [] ourArray = GetArray(SIZE, max, min);
    PrintArray(ourArray);
  

}

void ReceiveSizeAndRangeOfArray( out int size, out int maxVal, out int minVal)
{
    Console.WriteLine("Введите размер массива");
     size = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите максимальное значение массива");
      maxVal = int.Parse(Console.ReadLine()!);

 Console.WriteLine("Введите минимальное значение массива");
     minVal = int.Parse(Console.ReadLine()!);
    
}
int[] GetArray(int size, int maxVal, int minVal)
{
    int [] arr = new int[size+1];
    for ( int i =0; i< size+1; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal+1);

    }
    return arr;

}
void PrintArray(int[] arr)

{
    Console.WriteLine("\nНаш массив");
    for ( int i = 0; i<arr.Length-1; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}