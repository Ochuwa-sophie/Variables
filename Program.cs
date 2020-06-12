using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
        //     int x;
        //     int y;
        //     //Please Mr. .NET runtime, allocate space in my computer memory
        //     // sufficient for a variable that will hold integers.

        //     x = 4 + 3;
        //     y = x + 3;
        //     //Hello variables here goes your values. 
        //     //Now you have a purpose (yup from the beginning you were made for integers dear.)
        //    //Incase you don't know, integers are numbers wthout decimals and mathematical values.
           
        //     Console.WriteLine(y); //reading/retrieving the values
            // string MyFirstName;
            // MyFirstName = "Ochusko";

            // string MyFirstName = "Ochusko"; 
            // Console.WriteLine(MyFirstName);
           
           int x = 7;
          // string y = "Sophie";
          string y = "5";
            string myFirstTry = x.ToString() + y;

           // int mySecondTry = (x + y);
            int mySecondTry = x + int.Parse(y);


            Console.WriteLine(myFirstTry);
             Console.WriteLine(mySecondTry);
            Console.ReadLine();
            //because dear variable, you were created to be used not to stay idle, I now have to call the data you have stored.
        }
    }
}
