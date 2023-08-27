using System;


class AccountCheck{
    public int account_no {get; set;}
    // public int account_no;

    public AccountCheck(int acc_no){
        this.account_no = acc_no;
        Console.WriteLine("Account Check completed");
    }
}