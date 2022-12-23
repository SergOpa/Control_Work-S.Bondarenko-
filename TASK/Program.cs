// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using static System.Console;

// выбераем размер исходного массива
Clear();
Write("Введите количество элементов исходного массива: ");
int size = int.Parse(ReadLine());
WriteLine();
// выводим исходный массив используя метод
string[] strArr = initArr(size);
WriteLine("Исходный массив:");
WriteLine($"[{String.Join("  ", strArr)}]");
WriteLine();
// метод для исходного массива
string[] initArr(int size)
{
    string[] strRND = new string[size];
    for (int i = 0; i < size; i++)
    {
        //инициализируем строку str из которой мы будем брать символы
        Random res = new Random();
        String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz"; // 62 символа
        int sizestr = new Random().Next(1, 7); // длина строки
        String ran = "";
        for (int j = 0; j < sizestr; j++)
        {
            // индекс символа
            int x = res.Next(62);
            ran = ran + str[x];
        }
        strRND[i] = ran;
    }
    return strRND;
}
// определяем размер производного массива
int newSize = 0;
foreach (var value in strArr)
{
    if (value.Length <= 3) newSize++;
}
// заполняем производный массив
string[] finArr = new string[newSize];
int finSize = 0;
foreach (var fin in strArr)
{
    if (fin.Length <= 3)
    {
        finArr[finSize] = fin;
        finSize++;
    }
}
WriteLine("Производный массив:");
WriteLine($"[{String.Join("  ", finArr)}]");


