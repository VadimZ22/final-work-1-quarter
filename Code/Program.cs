/* Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых 
   меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
   выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
   исключительно массивами*/

//string[] array1 = {"1234", ")))", "ANY", "fhkjfgfji", "12"};


Console. Clear();
string[] array = EnterArray();
PrintArray(array);
PrintArray(Sample(array));


string[] EnterArray()
{
    Console.WriteLine("Enter amont of elements");
    int amount = int.Parse(Console.ReadLine());
    string[] array = new string[amount];

    for (int i = 0; i < amount; i++)
    {
        Console.Write($"Enter {i + 1} element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


string[] Sample(string[] arr)
{
    int count = 0;
    foreach (string s in arr)
    {
        if (s.Length <= 3) count++;
    }

    string[] newarr = new string[count];
    if (count > 0)
    {
        int newarrIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
                newarr[newarrIndex++] = arr[i];
        }
    }
    return newarr;
}


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
            Console.Write(", ");
                
    }
    Console.Write("]");
    Console.WriteLine();
}
