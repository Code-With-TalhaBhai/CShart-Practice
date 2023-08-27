using System;


namespace HelloWorld
{
    class Program
        {

            static int sum(){
                int a = 543;
                int b = 464;
                return a  + b;
            }

            static void Main(string[] args){
                Console.WriteLine("Hello Worlding");
                Console.WriteLine("I Love c#");
                int summation = sum();
                Console.WriteLine("The sum of two numbers are: "+sum());
                // As constructors cannot be overridden
                // Player p1 = new Player("Spider",20,skills_level.Intermediate,76);
                // p1.printover();
                // Player p1 = new Player();
                // p1.get_details("Avengers",19,skills_level.Beginner,53);
                // p1.print();

                // Static method doesn't need object to be instantiate
                // Player.static_work();
                // Singelton.work(); // Not static gives error need object to be instantiate
                // p1.work(); // Correct
            }
        }
}
