// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double GetDistanceIn3D()

{
    Console.WriteLine("Введите координаты Х точки А");
    int tochka_AX= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты Y точки А");
    int tochka_AY = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты Z точки А");
    int tochka_AZ = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты X точки B");
    int tochka_BX= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты Y точки B");
    int tochka_BY = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты Y точки B");
    int tochka_BZ = Convert.ToInt32(Console.ReadLine());

    
        double result = Math.Sqrt(Math.Pow(tochka_BX - tochka_AX, 2) + Math.Pow(tochka_BY - tochka_AY, 2) + Math.Pow(tochka_BZ - tochka_AZ, 2));
        
        return result;
        // Math.Pow - вовзведение в степень (что вовзводим, в какую степень)
        // Math.Sqrt - квадратный корень
    
}

double result = GetDistanceIn3D();
Console.WriteLine(result);