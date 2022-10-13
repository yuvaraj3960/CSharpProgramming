using System;
namespace ValidInput;
class Program{
    public static void Main(string[] args)
    {
        string condition="yes";
        do{
        System.Console.WriteLine("Enter the number");
        bool number = int.TryParse(Console.ReadLine(),out int result);
        if(number)
        {
            System.Console.WriteLine("Input in correct Format");
            if(result<=10)
            {
                System.Console.WriteLine("Valid Input");
                condition="no";
            }
            else{
                System.Console.WriteLine("Invalid Input");;
            }
        }
        else
        {
            System.Console.WriteLine("Input was not in correct format");
            condition="yes";
        }
        }while(condition=="yes");
    }
}
