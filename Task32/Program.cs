// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

//Получаем число
int GetValueIntFromConsole(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return int.Parse(value);
}

//Создаем метод для инициализации массива от 0 до 1
int[] ArrayInit(int number)
{
    int[] array = new int[number];
    Random randomValue = new Random();

    for(int i = 0; i < number; i++)
    {
        array[i] = randomValue.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach(int item in array)
    {
        Console.Write($"{array[item]}");
    }
}

//Создаем переменную с помощью которой вызываем метод для получения числа 
int getInt = GetValueIntFromConsole("Введите число элементов массива: ");
//Создаем переменную с помощью которой вызываем метод для инициализации массива
int[] array = ArrayInit(getInt);

PrintArray(array);