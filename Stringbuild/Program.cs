using System;
using System.Text;


namespace Stringbuild
{
    
    /*
    public enum dept { HR=111,Manager,Admin,Sales,developer}
    public enum gender {Male,Female}
    public class emp
    {
        private string name = "";
        private int id;
        private gender gen;
        private dept d;
         
        public emp(int eid,string nm, dept dp,gender g)
        {
            id =eid;
            name =nm;
            d =dp;
            gen = g;

        }
        public override string ToString()
        {
            return $"emp id:{id} Name of Employee :{name} and dept is: {d} Gender is {gen} ";
        }
    }*/
    class Program
    {
        static void DisplayName(params string[] names)
        {
            System.Console.WriteLine(names.Length);
            foreach (var nm in names)
            {
                System.Console.WriteLine(nm);
            }
        }
        
        static void Main(string[] args)
        {
            DisplayName("Tanmay");
            DisplayName("Tanmay","Ankita","Sanket");
            DisplayName("Tanmay","Ankita","Sanket","vyanky");
           /* emp em1 = new emp(1,"Sam", dept.developer,gender.Male);
            emp em2 = new emp(2,"sanny", dept.HR,gender.Male);
            emp em3 = new emp(3,"danny", dept.Admin,gender.Male);
            emp em4 = new emp(4,"kavin", dept.Sales,gender.Male);

            System.Console.WriteLine(em1);
            System.Console.WriteLine(em2);
            System.Console.WriteLine(em3);
            System.Console.WriteLine(em4);*/




            /*StringBuilder strsb = new StringBuilder("I am Ajay");
            Console.WriteLine(strsb);
            strsb.Append(" designation is developer");
            float salary = 28000.00f;
            strsb.AppendFormat("my salary is {0:C}", salary);

            strsb.Insert(10, " Thank you ");
            Console.WriteLine(strsb);

            strsb.Remove(14, 5);
            Console.WriteLine(strsb);

            strsb.Replace("developer", "manager");
            Console.WriteLine(strsb);




        //    string str = "Hello Freshers!!!";
        //    System.Console.WriteLine(str);
        //    System.Console.WriteLine(str.Length);
        //    System.Console.WriteLine(str.ToUpper());
        //    System.Console.WriteLine(str.ToLower());
        //    System.Console.WriteLine(str.IndexOf("F"));*/
           
        }
    }
}
