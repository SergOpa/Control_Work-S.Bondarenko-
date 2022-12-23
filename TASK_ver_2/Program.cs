using static System.Console;

Clear();
Write("Введите количество элементов исходного массива: ");
int size = Convert.ToInt32(ReadLine());
string[] finArr = new string[size];
int len = 3;
int pos = 0;
for (int i = 0; i < size; i++)
{
    WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(ReadLine());
    if (element.Length <= len)
    {
        finArr[pos] = element;
        pos++;
    }
}
WriteLine();
WriteLine("Производный(искомый) массив:");
PrintArray(finArr);
void PrintArray(string[] array)
{
    Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        
        Write(array[i] + " ");
    }
    Write("]");
}