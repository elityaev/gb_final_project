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


