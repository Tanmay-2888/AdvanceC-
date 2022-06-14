using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
             string userInput, systemInput;

            int randomNum;



            Console.Write("Give an input from Rock/ Paper/ Scissor ");

            userInput = Console.ReadLine();

            Random rnd = new Random();

            randomNum = rnd.Next(1, 4);

            switch (randomNum)

            {

                case 1:

                    systemInput = "Rock";

                    Console.WriteLine("Computer chose Rock");

                    if (userInput == "Rock")

                    {
                        Console.WriteLine("It is a draw");

                    }
                    else if(userInput == "Paper")

                    {

                        Console.WriteLine("You Loose");

                    }

                    else

                    {

                        Console.WriteLine("YOu win");

                    }

                    break;

                case 2:

                    systemInput = "Paper";

                    Console.WriteLine("Computer chose Paper");

                    if (userInput == "Rock")

                    {

                        Console.WriteLine("You Loose");

                    }

                    else if (userInput == "Paper")

                    {

                        Console.WriteLine("It is a draw");

                    }

                    else

                    {

                        Console.WriteLine("You win");

                    }

                    break;

                case 3:

                    systemInput = "Scissor";

                    Console.WriteLine("Computer chose Scissor");

                    if (userInput == "Rock")

                    {

                        Console.WriteLine("You Win");

                    }

                    else if (userInput == "Paper")

                    {

                        Console.WriteLine("You Loose");

                    }

                    else

                    {

                        Console.WriteLine("It is a draw");

                    }

                    break;

                default:

                    Console.WriteLine("invalid entry!");

                    break;

            }
        }
    }
}
