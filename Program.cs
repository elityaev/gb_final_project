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


