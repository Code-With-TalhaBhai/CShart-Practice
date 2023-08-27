using System;


class MakeTransaction{

    public int amount {get; set;}
    // public int amount;

    public MakeTransaction(int amount){
        this.amount = amount;

        Console.WriteLine("Transaction done");
    }

}