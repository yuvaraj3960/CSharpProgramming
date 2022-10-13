using System;
namespace OperatorOverloading;

class Program{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.2,3.2,4.2);
        Box box2=new Box(2.3,3.2,6.0);
        

        double volume=0.0;

        volume=box1.CalculateVolume();

        Console.WriteLine("Volume of Box1 : {0}",volume);

        volume=box2.CalculateVolume();
        Console.WriteLine("Volume of Box2 : {0}",volume);

        Box box3=new Box();
        box3=box1+box2;

        volume=box3.CalculateVolume();
        Console.WriteLine("Volume of Box3"+volume);
        
    }
    
}
