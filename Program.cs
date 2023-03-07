string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input array[{i}]: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] ShowArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] array3 = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array3[j] = array[i];
            j++;
        }
    }
    return array3;
}


Console.WriteLine("Input a size: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(n);
PrintArray(myArray);
Console.WriteLine($"New array: ");
string[] newArray = ShowArray(myArray);
PrintArray(newArray);
