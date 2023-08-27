// The primary goal of facade pattern is to provide a simple
// and well define interface to a more complex desing pattern or API'S
// like multiple subclasses instantiating in single class in facade pattern

using System;

    class FacadePattern{

        public FacadePattern(int num){
        AccountCheck acc_check = new AccountCheck(num);
        PinCheck pin_check = new PinCheck(num);
        MakeTransaction transaction = new MakeTransaction(num);
            Console.WriteLine("Facade Pattern Completed");
        }

        // Console.WriteLine("Facade Pattern Completed");

    }