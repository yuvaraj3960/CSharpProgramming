using System;
namespace AbstractClasses
{
    class Program{
        public static void Main(string[] args)
        {
            Syncfusion sf=new Syncfusion();
            sf.Name="Developer";
            sf.Salary(30);

            TCS job=new TCS();
            job.Name="Testing engineer";
            job.Salary(15);

            Console.ReadKey();


        }
    }
}
