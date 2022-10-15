//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
void Main()
{
   int SIZE = 10;
   double[] ourArray = GetArray(SIZE);
   PrintArray(ourArray);
   double maxNum = FindMaxOfArray(ourArray);
   double minNum = FindMinOfArray(ourArray);
   Console.WriteLine($"\nРазница между максимальным {maxNum} и минимальным {minNum} = {maxNum - minNum}");

}
double[] GetArray(int size)
{
    double[] arr = new double[size];
    for( int i = 0; i<size; i++)
    {
        //arr[i] = Random.NextDouble();
        arr[i] = Convert.ToDouble(new Random().Next(-10,1000))/100;


    }
    return arr;

}


void PrintArray(double[] arr)
{ int i = 0;
    foreach(double el in arr)
    {
        Console.Write($" {arr[i] }");
        i++;
    }

}


double FindMaxOfArray(double[] arr)
{double max = 0;
foreach(double el in arr)
{
    if (el > max)
    {
        max = el;
    }
}
return max;
}


double FindMinOfArray(double[] arr)
{ double min = 0;
foreach (double el in arr)
{
    if(el<min)
    {
        min = el;
    }
}
    return min;
}


Main();