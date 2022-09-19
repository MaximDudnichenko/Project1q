// the method returns an array of strings entered by the user
string[] FillArray(int value)
{
    string[] result = new string[value];
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива строк: ");
        result[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return result;
}

// the method outputs an array of strings to the screen
void PrintArray(string[] array)
{
    Console.WriteLine($"['{String.Join("', '", array)}']");
    Console.WriteLine();
}

