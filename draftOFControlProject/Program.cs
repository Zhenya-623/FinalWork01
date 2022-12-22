// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []




//команда для ввода массива
Console.WriteLine("Введите массив строк отделяя каждую элемент массива запятой без пробелов:");
//в переменную arrayStr передаем введенные числа
string arrayStr = Console.ReadLine() ?? "";
string[] array = arrayStr.Split(",");

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        char[] array = arr[i].ToCharArray();
        int count = 0;
        for (int y = 0; y < array.Length; y++)
        {
            count++;
        }
        if (count <= 3)
        {
            if (i < arr.Length - 1) System.Console.Write($"{arr[i]}, ");
            else Console.Write($"{arr[i]}");
        }
    }
    Console.WriteLine("]");
}
Console.WriteLine("Массив строк длина которых меньше либо равна 3 символам");
PrintArray(array);