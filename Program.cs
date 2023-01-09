System.Console.Write("Введите трехзначное число");

int number = int.Parse(System.Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = firstDigit % 10;

 System.Console.WriteLine(secondDigit);
