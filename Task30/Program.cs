//Показать кубы чисел, заканчивающихся на четную цифру

void GetCubeNumberS(int number)
{
    int result = 0;
    for (int n = 1; n <= number; n++)
    {
        result = n*n*n;
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
