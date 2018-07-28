using System;

namespace CG_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a number 1 through 12."); //opening command
            string userValue = Console.ReadLine(); //establishing input variable

            string message = ""; //establishing my output variable

            if (userValue == "1") //my first "if" statement followed by "else if" for each month
                message = "January";
            else if (userValue == "2")
                message = "February";
            else if (userValue == "3")
                message = "March";
            else if (userValue == "4")
                message = "April";
            else if (userValue == "5")
                message = "May";
            else if (userValue == "6")
                message = "June";
            else if (userValue == "7")
                message = "July";
            else if (userValue == "8")
                message = "August";
            else if (userValue == "9")
                message = "September";
            else if (userValue == "10")
                message = "October";
            else if (userValue == "11")
                message = "November";
            else if (userValue == "12")
                message = "December";

            Console.WriteLine(message); //command to output for string "message"
            Console.ReadLine();


        }
    }
}
