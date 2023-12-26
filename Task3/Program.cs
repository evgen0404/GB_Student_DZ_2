// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

class Program

{
    static void Main()
    {
       Console.Write("Введите число из отрезка от 10 до 99: ");

       int number = Convert.ToInt32(Console.ReadLine());

       int number1 = number / 10;

       int number2 = number % 10;

       if (number1 > number2)

         Console.Write(number1);
      
       else
         
        Console.Write(number2);
    }
}