using System;
namespace Circle;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle:");
        int radius=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Your choice:");
        int choice=int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
            {
                double area=3.14*3.14*radius;
                Console.WriteLine("Area of a circle"+" "+area);
                break;
            }
            
            case 2:
            {
                double perimeter=2*3.14*radius;
                Console.WriteLine("Perimeter of a circle"+" "+perimeter);
                break;
            }
            case 3:
            {
                double diameter=2*radius;
                Console.WriteLine("Diameter of a circle"+" "+diameter);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid input");
                break;
            }
        }
    }
}

