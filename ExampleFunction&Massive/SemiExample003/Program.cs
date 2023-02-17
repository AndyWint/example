// 
// 1.Создать массив


int[] CreateArray(int length)
{
  return new int[length];
}

// Распечатать массив
void Print(int[] array)
{
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    Console.Write(array[index]);
    ++index;
  }
  Console.WriteLine();
}

int[] arr = CreateArray(10);


// Заполнение 

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index =0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

FillArray(arr);
Print(arr);
// Перемешивание

int Resort(int[] arr)
{
    int count = arr.Length;
    int help = 0;
    int index = 0;
    while(index < (count / 2) )
    {
    help = arr[index];
    arr[index] = arr[count - 1 -index];
    index++;
    arr[count - 1 -index] = help;
    }
    return arr[index];
}

Resort(arr);
Print(arr);


