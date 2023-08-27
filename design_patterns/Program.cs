using System;

namespace HelloWorld
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Pattern program is running");

            // Later could be removed
            // Singelton single = new Singelton();
            // // Static method doesn't need object to be instantiate
            // Singelton.static_work();
            // // Singelton.work(); // Not static gives error need object to be instantiate
            // single.work(); // Correct


            // Real Singelton starts here
            // Singelton slt1 = new Singelton();
            // Singelton slt2 = Singelton.Instance()
            
            new Singelton();
            new Singelton(); 
            new Singelton();
            new Singelton();
            Singelton.counted();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Facade pattern starting");
         // Facade Design Pattern working
            FacadePattern fac_pattern = new FacadePattern(542);
            

        }
    }
}