/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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

int[] CreateRandomArray(int demension)
{
  int[] array = new int[demension];
  Random rnd = new Random();

  for (int i = 0; i < demension; i++)
  {
    array[i] = rnd.Next(-99, 100);
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

int SummItemsFromOddPosition(int[] array)
{
  int summ = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if( (i % 2) != 0)
    {
      summ += array[i];
    }
  }

  return summ;
}



int demension = GetNumber("Enter demension of the array");
int[] array = CreateRandomArray(demension);
int summOddItems = SummItemsFromOddPosition(array);

Console.Write("[");
PrintArray(array);
Console.Write($"] -> {summOddItems}");
