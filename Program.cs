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

string[] ElementSelection(string[] array)
{
    string[] result = new string[0];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref result, j + 1);
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

