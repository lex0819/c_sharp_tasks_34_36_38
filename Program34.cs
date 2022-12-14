/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int GetNumber(string message){
  int result = 0;

  while (true)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine() , out result) && result > 0)
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

int[] CreateRandomArray(int demension)
{
  int[] array = new int[demension];
  Random rnd = new Random();

  for (int i = 0; i < demension; i++)
  {
    array[i] = rnd.Next(100, 1000);
  }

  return array;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}, ");
  }
}

int CounterEvenNumbers(int[] array)
{
  int summ = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if( (array[i] % 2) == 0)
    {
      summ ++;
    }
  }

  return summ;
}



int demension = GetNumber("Enter demension of the array");
int[] array = CreateRandomArray(demension);
int evenCounter = CounterEvenNumbers(array);

Console.Write("[");
PrintArray(array);
Console.Write($"] -> {evenCounter}");
