/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int GetNumber(string message){
  int result = 0;

  while (true)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine() , out result))
    {
      break;
    }
    else
    {
      Console.WriteLine("You've entered incorrect number, please try again");
    }
  }
  return result;
}

//create array of real numbers beetwen min and max. Type C# is double.
double[] CreateRandomArray(int demension, double min = 0.01, double max = 100.01)
{
  double[] array = new double[demension];
  Random rnd = new Random();

  for (int i = 0; i < demension; i++)
  {
    array[i] = min + rnd.NextDouble() * (max - min);
  }

  return array;
}

void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

//tuple for min and max items
(double min, double max, double diff) FindMinMaxElements(double[] array)
{
  double diff = 0;
  double min = array[0];
  double max = array[0];

  for (int i = 0; i < (array.Length - 1); i++)
  {
    if(min > array[i+1])
    {
      min = array[i+1];
    }
    if(max  < array[i+1])
    {
      max = array[i+1];
    }
  }

  diff = max - min;

  return (min, max, diff);
}

int demension = GetNumber("Enter demension of the array");
double[] array = CreateRandomArray(demension);
(double min, double max, double diff) = FindMinMaxElements(array);

Console.Write("[");
PrintArray(array);
Console.Write($"] -> {diff}");
