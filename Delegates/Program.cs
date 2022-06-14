using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


namespace Delegates
{
    public Delegate void Mydel();
    public class Student
    {
        public event Mydel fail;
        public event Mydel Distinction;

        public void AcceptMarks(int marks)
        {
            if (marks < 40)
            {

                fail();

            }
            else if (marks >= 75)
            {
                Distinction();   
            }
            System.Console.WriteLine($"Your Score is {marks}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
