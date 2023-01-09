System.Console.Write("Введите число");

int number = int.Parse(System.Console.ReadLine());

if (number < 100)
  {
    System.Console.WriteLine("Третьей цифры нет");
    
  }
  
else
{
    System.Console.WriteLine("Третья цифра есть");
}

 int firstDigit = number / 10;
 int secondDigit = firstDigit % 10;
 int thirdDigit = secondDigit % 10; 

System.Console.WriteLine(thirdDigit);