// // Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// // длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// // либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// // лучше обойтись исключительно массивами.

string[] CreateStringArray(int size)
{
    string[] array = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-ое значение массива: ");
        string text = Convert.ToString(Console.ReadLine());
        array[i] = text;
    }
    return array;
}

string[] CreateNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
        int index = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateStringArray(size);
CreateNewArray(myArray);
ShowArray(CreateNewArray(myArray));