// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 


void Polindrom5Digit (int number)
{
int firstDigit = number/10000;
int secondDigit = number/1000%10;
int lastDigit = number%10;
int penultimateDigit = number%100/10;

if (firstDigit == lastDigit && secondDigit == penultimateDigit)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
}

Console.WriteLine("Enter your five digit number: ");
int numb = Convert.ToInt32(Console.ReadLine());
Polindrom5Digit(numb);
