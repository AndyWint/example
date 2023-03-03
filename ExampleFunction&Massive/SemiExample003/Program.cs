// Перемешивание массива

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


// Заполнение 

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = index;
        index++;
    }
}


// Перемешивание

int Resort(int[] arr)
{
    int count = arr.Length - 1;
    int help = 0;
    int index = 0;
    while (count >= 1)
    {
        int rnd = new Random().Next(0, 9);   // Выбор случайного числа 
        index = rnd + 1;
        help = arr[index];
        arr[index] = arr[count];
        arr[count] = help;
        count--;
        
    }
    return help;
}

int[] arr = CreateArray(10);
FillArray(arr);
Print(arr);
Resort(arr);
Console.WriteLine();
Print(arr);


