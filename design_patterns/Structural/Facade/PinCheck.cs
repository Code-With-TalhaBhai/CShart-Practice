using System;

class PinCheck {

    public int pin {get; set;}
    // public int pin;

    public PinCheck(int pin){
        this.pin = pin;
        Console.WriteLine("Pin has successfully matched");
    }
}