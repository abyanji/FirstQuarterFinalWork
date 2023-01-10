Console.Clear();

string[] DataEntry(string message)
{
    System.Console.WriteLine(message);
    string[] array = new string[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (Console.ReadLine());
    }
    return array;
}

int FindSelectedLegnth(string[] array, int elemLength)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elemLength) quantity++;
    }
    return quantity;
}

void TransferElemnts(string[] array, string[] newArray, int elemLength)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elemLength)
        {
            newArray[j] = array[i];
            j++;
        }
    }
}

int stringLength = 3;
string[] arrayString = DataEntry("Enter the array elements ");
int requiredLength = FindSelectedLegnth(arrayString, stringLength);
string[] requiredArray = new string[requiredLength];
TransferElemnts(arrayString, requiredArray, stringLength);
System.Console.Write($"[{(string.Join("; ", arrayString))}]");
System.Console.WriteLine();
System.Console.Write($"[{(string.Join("; ", requiredArray))}]");