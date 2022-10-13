using System;
namespace month;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int month=int.Parse(Console.ReadLine());

        switch(month)
        {
            case 1:
            {
                Console.WriteLine("31 days");
                break;
            }
                case 2:
            {
                Console.WriteLine("28 days");
                break;
            }
                case 3:
            {
                Console.WriteLine("31 days");
                break;
            }
                case 4:
            {
                Console.WriteLine("30days");
                break;
            }
                case 5:
            {
                Console.WriteLine("31 days");
                break;
            }
                case 6:
            {
                Console.WriteLine("30 days");
                break;
            }
                case 7:
            {
                Console.WriteLine("31 days");
                break;
            }
                case 8:
            {
                Console.WriteLine("31 days");
                break;
            }
                case 9:
            {
                Console.WriteLine("30 days");
                break;
            }
                case 10:
            {
                Console.WriteLine("31 days");
                break;
            }
                case 11:
            {
                Console.WriteLine("30 days");
                break;
            }
                case 12:
            {
                Console.WriteLine("31 days");
                break;
            }
            default:
            {
                Console.WriteLine("Inavlid Input");
                break;
            }
        
        }
    }
}
