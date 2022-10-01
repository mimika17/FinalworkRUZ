// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводите строки массива");
string[] FillArray(int n)
{
    string[] collection = new string[n];
    int index = 0;
    while (index < n)
    {

        collection[index] = Convert.ToString(Console.ReadLine());
        index++;
    }
    return collection;
}
string[] array = FillArray(n);
string[] ShortArray(string[] array)
{

    int t = new Random().Next(0, 4);
    string[] shortarray = new string[t];
    int[] pos = new int[t];
    for (int i = 0; i < t; i++)
    {
        int x = new Random().Next(0, array.Length);
        shortarray[i] = array[x];
        pos[i] = x;
        if (i >= 1)
            for (int j = 0; j < i; j++)
            {
                while (pos[i] == pos[j])
                {
                    x = new Random().Next(0, array.Length);
                    shortarray[i] = array[x];
                    pos[i] = x;
                    j = 0;
                }
            }
    }


    return shortarray;
}
Console.WriteLine(string.Join(" ,", array));
string[] array1 = ShortArray(array);
Console.WriteLine($"[{string.Join(" ,", array1)}]");