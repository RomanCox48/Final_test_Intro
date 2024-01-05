
bool CheckElements(string[] array, int index)
{
    if (index < 0 || index >= array.Length)
        return false;
    return array[index].Length <= 3;
}

int CountElements(string [] array)
{
    int total = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (CheckElements(array, i) == true)
        {
            total++;
        }
    }
    return total;
}

void newArray(string[] array, int count)
{
    string[] newArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (CheckElements(array, i) == true)
        {
            string temp = array[i];
            newArray[count] = temp;
            count++;
        }
    }
    Console.WriteLine(String.Join(" ", newArray));

}

Console.WriteLine("Введите строку, состоящую из слов, разделенных пробелами:");
string[] array = Console.ReadLine().Split(" ").ToArray();
int count = CountElements(array);
newArray(array, count);