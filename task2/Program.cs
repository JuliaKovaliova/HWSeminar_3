// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance3D (int xA, int xB, int yA, int yB, int zA, int zB)
{
    double distance = Math.Sqrt ((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
    return distance;
}

Console.WriteLine("Enter x coord of A");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y coord of A");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter z coord of A");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter x coord of B");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y coord of B");
int yCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter z coord of B");
int zCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Distance is {(Distance3D (xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB)):f2}");
