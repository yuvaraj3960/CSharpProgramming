using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of an arry:");
        int size=int.Parse(Console.ReadLine());
        int i;
         
        string[] names=new string[size];
        Console.WriteLine("Enter the names:");
        
        for(i=0;i<names.Length;i++)
        {
           
            names[i]=Console.ReadLine();
        } 
        Console.WriteLine("The listed names:");   
        for(i=0;i<names.Length;i++)
        {   
            
            Console.WriteLine(names[i]);
        }    
        
        
        Console.WriteLine("Enter the name for searching");
        string full_name=Console.ReadLine();
        int count=0;
        for(i=0;i<names.Length;i++)
        {
            if (full_name==names[i])
            {
                Console.WriteLine("The name is present in array");
                Console.WriteLine("The index is"+" "+i);
                count++;
                
            
            }

        else if(full_name==names[i])
        
        {
            Console.WriteLine("The name is not present in an array");
        }

        }
        Console.WriteLine("Enter the name for searching");
        string full_name1=Console.ReadLine();
        
        foreach(string name in names)
        {
            
            if (name==full_name1)
            {
                Console.WriteLine("The name is present in array");
                
                
                break;
            }    
        
        else if(name!=full_name1)   
        {
                Console.WriteLine("The name is not present in array");
        }
            
            
          }
}


}


        
        
        
        


    
