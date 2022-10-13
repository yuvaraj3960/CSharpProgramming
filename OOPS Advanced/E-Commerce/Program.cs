using System;
namespace E_Commerce;
class Program{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFiles();
        Operation.MainMenu();
        Files.WriteFiles();
        
    }
}
