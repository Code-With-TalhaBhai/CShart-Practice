using System;

// For checking Inheritance
    class Human {
        public string name;
        public int age;

        // Constructors cannot be override
        // public Human(string name,int age){
        //     this.name = name;
        //     this.age = age;
        // }

        // Making method which would be override in derived class
        // public virtual void get_details(string name,int age){
        //     this.name = name;
        //     this.age = age;
        // }

        public virtual void printover(){
        // public void printover(){
            Console.WriteLine("Human is printOver");
        }


        public void printBio(){
            Console.WriteLine("The Human name is: "+this.name+" and Human age is: "+this.age);
        }

    }