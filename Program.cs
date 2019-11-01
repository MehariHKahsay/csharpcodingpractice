using System;

namespace ProgrammingPractice
{
    public class Programs
    {
        public static  void Main(string[] args)
        {
            Console.WriteLine("Hello: Mehari Kahsay");
            Console.WriteLine(Exercise());
            UserInput();

        }
        public static string Exercise()
        {
            int myInt = 9;
            double myDouble = myInt;
            return ("My Int" + myInt + " My double:" + myDouble);

        }

        public static void UserInput()
        {
            //User Input and casting data types
            Console.WriteLine("Enter your username:");
            int username = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Your username is: " + username);
            
            //Math Methods
            Console.WriteLine("Max is: " + Math.Max(2, 1));

            //Strings and Size
            string myname = "Mehari Kahsay";
            string middlename = "Habteyesus";
            Console.WriteLine("My Name size is: " + myname.Length);
            Console.WriteLine("My Name Lower is: " + myname.ToLower());
            Console.WriteLine("My Name Upper is: " + myname.ToUpper());
            Console.WriteLine("My Name GetHash is: " + myname.Length.GetHashCode());

            //Use of String Interpolation ($)
            string fullname = $"My Fullname is: {myname.Substring(0,6)} {middlename} {myname.Substring(6,7)}";
            Console.WriteLine(fullname);
            Console.WriteLine(myname.IndexOf("y"));





        }
    }

}