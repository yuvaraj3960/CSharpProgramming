using System;
namespace Cricket;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the country:");
        string country=Console.ReadLine();

        switch(country)
        {
            case "India":
            {
                Console.WriteLine("1.Gambhir");
                Console.WriteLine ("2.Ashwin");
                Console.WriteLine ("3.Dhoni");
                Console.WriteLine  ("4.Jadeja ");
                break;            
            }
            case "Pakistan":
            {
                Console.WriteLine(" 1.Babar Azam");
                Console.WriteLine ("2.Mohammed Rizwan");
                Console.WriteLine ("3.Shaheen Afridi");
                break;
            }
            case "Bangladesh":
            {
                Console.WriteLine("1.Shakib Al Hasan");
                Console.WriteLine ("2.Liton Das");
                Console.WriteLine ("3.Mustafizur Rahman");
                break;
            }
            default:
            

       }   }   }    
    

