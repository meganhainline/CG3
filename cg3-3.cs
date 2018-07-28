using System;

namespace CG3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime x = DateTime.Now;        //STATEMENT - code that ends in a semi-colon
            Console.WriteLine(x.ToLongDateString()); //Shows Date and Time

            Console.WriteLine("Today you will see what I have learned!"); //Opening statement

            Console.WriteLine("What is your name?"); 
            Console.Write("type your first name:");
            String myFirstName;                  //Demonstrates use of strings
            myFirstName = Console.ReadLine();
            Console.WriteLine("Hello " + myFirstName + "!");


            Console.Write("Do you want to know about me? Enter yes/no");
            string userValue = Console.ReadLine();
            string message = "";
            if (userValue == "yes")   //EXPRESSION - requires no semi-colon
                message = "I am Megan";    //OPERATOR - the = is the operator and states the action being taken
            else if (userValue == "Yes") //just in case the user capitalizes the "Y" since its case sensetive
                message = " I am Megan";
            else message = "That is too bad";
            Console.WriteLine(message);
      
            int a = 27; //Working with integers!
            int b = 5;
            int age = a + b;
                Console.WriteLine("I am " + age + " years old."); //string interpolation
 
            string size = ("tall ");    //string cacatenation
            string color = ("yellow ");   //OPERAND - color is the operand bc it is the "subject" of the line of code
            string animal = ("giraffes ");
            Console.WriteLine("My favorite animal is " + size + color + animal + ".");
            Console.ReadLine();


        }
    }
}
