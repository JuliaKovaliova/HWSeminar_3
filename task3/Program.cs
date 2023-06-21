// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void CubeFrom1toN (int numberN)
{
    int current = 1;
    while (current <= numberN)
    {
        double result = Math.Pow(current, 3);
        Console.Write($"{result:f0}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

CubeFrom1toN(number);



// программа для положительных чисел больше 0