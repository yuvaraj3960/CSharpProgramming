using System;
namespace Example9;
class Program
{
public static void Main(string[] args)
{
    Console.WriteLine("Enter the Speed:");
    int speed=int.Parse(Console.ReadLine());
     
    Console.WriteLine("Enter the second:");
    int second=int.Parse(Console.ReadLine());

    int distancetravelled=speed*second*5/18;
    Console.WriteLine("Output"+" "+ distancetravelled);



}
}
