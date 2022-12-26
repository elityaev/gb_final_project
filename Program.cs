string[] FillArray(int size)
{
    string[] arr = new string[size];
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} строку из {size} строк");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int GetLengthNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count += 1;
    }
    return count;
}

string[] CreateNewArray( string[] arr, int size)
{
    int index = 0;
    string[] newArr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[index] = arr[i];  
            index += 1;
        }
    }
    return newArr;
}

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = FillArray(size);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
int arr_size = GetLengthNewArray(array);
Console.WriteLine($"Новый массив: [{string.Join(", ", CreateNewArray(array, arr_size))}]");
