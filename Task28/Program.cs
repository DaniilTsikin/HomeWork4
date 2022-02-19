// Подсчитать сумму цифр в числе

//Получаем число

int GetValueInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

//Создаём метод, для вычисления суммы цифр в полученном числе

int SumDigitNumber(int num)
{
   int sumDigit = 0;
   while(num > 0)
   {
    sumDigit = sumDigit + (num % 10);
    num = num / 10;
   }
   return sumDigit;
}

int number = GetValueInt("Введите число: ");
Console.WriteLine($"Дано число {number}");

int resultSum = SumDigitNumber(number);
Console.WriteLine($"Результат {resultSum}");

