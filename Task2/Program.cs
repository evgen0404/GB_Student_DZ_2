// Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной 
// четверти плоскости, в которой находится эта точка.

using System;

class Program

{
    static void Main()
    {
        Console.Write("Введите координаты точки X:");

        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координаты точки Y:");

        int y = Convert.ToInt32(Console.ReadLine());

    if (x > 0 && y > 0)
        
        Console.WriteLine("В 1-й четверти"); 
    
    else if (x < 0 && y > 0)
        
        Console.WriteLine("Во 2-й четверти");
        
    else if (x < 0 && y < 0)
        
        Console.WriteLine("В 3-й четверти");
        
    else if (x > 0 && y < 0)
        
        Console.WriteLine("В 4-й четверти");
        
    else 
        
        Console.WriteLine("Точка находится на оси координат");
        
    }
}

