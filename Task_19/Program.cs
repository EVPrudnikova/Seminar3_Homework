// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

string Five = Convert.ToString(Number);

if (Five[0] == Five[4] || Five[1] == Five[3])
{
    Console.WriteLine($"Введенное число {Number} является полиндромом!");
}
else
{
    Console.WriteLine($"Введенное число {Number} не является полиндромом");
}
