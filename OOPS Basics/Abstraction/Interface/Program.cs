using System;
namespace Interface 
{
    class Program{
        public static void Main(string[] args)
        {
            Draw dr=new Draw();
            dr.GetData(20,25);
            dr.CalculateArea();
        }
    }
}
