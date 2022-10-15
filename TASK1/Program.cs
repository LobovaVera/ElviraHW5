// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

void Main()
{
    Console.Clear();
    int SIZE;
    ReceiveSizeAndRangeOfArray(out SIZE);
    int [] ourArray = GetArray(SIZE);
    PrintArray(ourArray);
    HowManyEvenNumbersInArray(ourArray);

}

void ReceiveSizeAndRangeOfArray( out int size)
{
    Console.WriteLine("Введите размер массива");
     size = int.Parse(Console.ReadLine()!);
    
}
int[] GetArray(int size)
{
    int [] arr = new int[size+1];
    for ( int i =0; i< size+1; i++)
    {
        arr[i] = new Random().Next(100, 1000);

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
void HowManyEvenNumbersInArray (int[]arr)
{
    int count =0;
    for(int i =0; i<arr.Length-1; i++)
    {
       
        
        if(arr[i]%2==0 && arr[i]!=0)
        {
            count++;

        }
       
       
    }
      Console.WriteLine($"\nКоличество четных чисел в массиве равно {count}");
   
}
 
Main ();