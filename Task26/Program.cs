//Возведите число А в натуральную степень B используя цикл

//Получаем число
int GetValueInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}
//Получаем степень
int GetPower(string message)
{
     Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}
//Возводим полученное число в полученную степень
int RaisingANumberToAPower(int num1, int num2)
{   
    int result = 1;
    for(int i = 0; i < num2; i++)
    {
        result = result*num1;
    }
    return result;
}

int valueInt = GetValueInt("Введите число: ");
Console.WriteLine($"Число: {valueInt} ");

int power = GetPower("Введите степень числа: ");
Console.WriteLine($"Степень: {power}");

int raisingNumber = RaisingANumberToAPower(valueInt, power);
Console.WriteLine($"Резултат возведения: {raisingNumber}");