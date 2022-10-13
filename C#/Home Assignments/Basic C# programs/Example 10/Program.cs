using System;
namespace Example10;
class Program{
    public static void Main(string[] args)
    {
        int value1=15;
        int value2=20;
        bool a=true;
        bool b=false;
         
        if(value1>value2)
            {
                Console.WriteLine(a);

            }
        else
            {
                Console.WriteLine(b);

            }
        if(value1<value2)
            {
                Console.WriteLine(a);

            }
        else
            {
                Console.WriteLine(b);

            }
        if(value1>=value2)
            {
                Console.WriteLine(a);

            }
        else
            {
                Console.WriteLine(b);

            }
        if(value1==value2)
            {
                Console.WriteLine(a);

            }
        else
            {
                Console.WriteLine(b);

            }
        if(value1!=value2)
            {
                Console.WriteLine(a);

            }
        else
            {
                Console.WriteLine(b);

            }
        if(value1<=value2)
            {
                Console.WriteLine(a);

            }
        else
            {
                Console.WriteLine(b);

            }
        if(value1>=10 && value2>=10)
            {
                Console.WriteLine(a);

            }
        else
            {
                Console.WriteLine(b);

            }
        if(value1>=10 && value2>=30)
            {
                Console.WriteLine(a);

            }
        else
            {
                Console.WriteLine(b);

            }
        if(!(value1>20))
            {
                Console.WriteLine(a);

            }
        else
            {
                Console.WriteLine(b);

            }     
        String value=(value1==15)?"true":"false";
        Console.WriteLine("value"+" "+value);

        Console.WriteLine(++value1);
        Console.WriteLine(--value1);


    }
}
