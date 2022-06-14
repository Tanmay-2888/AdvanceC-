using System;
using System.Text;


namespace STRUCT_C_
{
    public class User
    {
        private int uid;
        private string name,city;

        public User (string city, string name, int uid,bool isUser= true)
        {
             this.city =  city;
            this.name = name;
            this.uid  = uid;

        }
        
           


        
    }

    
    /*public struct Dimension
    {
        int x,y;

        public Dimension (int x, int y)
        {
            this.x =x;
            this.y =y;
        }
        public void Display()
        {
            System.Console.WriteLine($"{x}{y}");
        }

    }*/
    class Program
    {
        /*static void Calculation(int a, int b, out int sum, out int sub, out int multiply, out int division)
        {
            sum = a+b;
            sub = a-b;
            multiply = a*b;
            division = a/b;
        }*/
        static void Main(string[] args)
        {
            User user1 = new User("Kolhapur", "Sandy",101);
            User user2 = new User(uid: 102, name:"Maddy",city :"Pune");
            User user3 = new User("Mumbai", "Kavin", 103, false);
            /*int a = 20, b =5, sum,sub,multiply,division;
            Calculation(a, b, out sum, out sub, out multiply, out division);
            System.Console.WriteLine($"add={sum} sub={sub} multiply={multiply} division={division}");
           /*Dimension d1 = new Dimension(10,12);
           d1.Display();

           Dimension d2=d1;*/
        }
    }
}


