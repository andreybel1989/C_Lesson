int[] array = { 12, 42, 3, 3224, 53, 5, 5, 64, 75 };
int n = array.Length;

//Console.WriteLine(n);
int index = 0;
int find = 75;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}