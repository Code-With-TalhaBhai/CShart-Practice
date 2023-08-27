using System;

namespace HelloWorld{
    enum skills_level {
            Beginner,
            Intermediate,
            Advance
        }
    // Inheritance
    // class Player : Human{
    class Player : Human , Male{ // Multiple Inheritance using interfaces
        public skills_level skills;
        public int health;
        public int energy{get;set;}

    
        // As constructor cannot be overriden
        public Player(string name,int age,skills_level skills,int health){
        // public Player(string name,int age,int health){
            this.name = name;
            this.age = age;
            this.skills = skills;
            this.health = health;
            this.energy = 53;
            print();
            young();
        }

        public override void printover(){
        // public void printover(){
            Console.WriteLine("Player is printOver");
        }

        // So we're overriding methods
        // public override void get_details(string name,int age,int health){

        // public override void get_details(string name,int age,skills_level skills,int health){
        //     this.name = name;
        //     this.age = age;
        //     this.skills = skills;
        //     this.health = health;
        //     print();
        // }

        public void young(){
            Console.WriteLine("Yes they are young");
        }

        public void print(){
            Console.WriteLine("The Player name is "+this.name);
            Console.WriteLine("Its age is "+this.age);
            Console.WriteLine("Its skill level is "+this.skills);
            Console.WriteLine("Its health is: "+this.health);
            Console.WriteLine("Its energy is: "+this.energy);
            // Console.WriteLine("It is young also: ",this.young);
        }

        public void work(){
                Console.WriteLine("Singelton working");
        }

        public static void static_work(){
                Console.WriteLine("Static Line is working");
        }

    }
}