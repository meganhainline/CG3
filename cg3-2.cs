using System;

namespace CG3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a number between 1 and 10");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "8")
                message = "You win!";
            //else (userValue != "8") *Does != mean "not equal"? I thought Scott said so in class but couldn't get it to run. Just wondered if it could be another way to code this.*
            //      message = "You lose!";
            else message = "You lose!";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
