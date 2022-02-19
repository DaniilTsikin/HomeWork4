//Показать кубы чисел, заканчивающихся на четную цифру

//Создаем функцию для нахождение кубов чисел до number
void GetCubeNumberS(int number)
{
    int result = 0;
    for (int n = 1; n <= number; n++)
    {
        result = n*n*n;
        //Исключаем нечётные кубы
        if(result % 2 == 0)
        {
            Console.Write($"{result} ");
        }
        else
        {
            Console.Write("");
        }
    }
}

Console.Write("Введите любое число от 1 и больше: ");
int input = int.Parse(Console.ReadLine());

GetCubeNumberS(input);
