using System;

// Singelton Design Pattern is used to instentiate a constructor
// even if it is not defined. It gives by-default constructor
// with default values of methods


class Singelton{

    static Singelton instance;
    public static int count = 0;

    public Singelton(){
        Singelton.count++;
    }

    public static void counted(){
        Console.WriteLine("The total count is: "+Singelton.count);
        // Console.WriteLine("The total count is: ");
        // Console.WriteLine("working");
    }

    public static Singelton Instance() {
            if(instance == null){
                instance = new Singelton();
            }
            return instance;
    }

    public void othermethods(){
        Console.WriteLine("Other Methods are working");
    }
}



  // public void work(){
    //     Console.WriteLine("Singelton working");
    //     static_work();
    // }

    // public static void static_work(){
    //     Console.WriteLine("Static Line is working");
    // }