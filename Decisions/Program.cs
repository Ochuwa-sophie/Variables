using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Branching with the If decision statement and the conditional operator
            Console.WriteLine("What flavour of ice cream do you want to purchase Chocolate, Banana, Vanlla or Cherry?");
            string userInput = Console.ReadLine();

            // string notification = "";
        
            //     if (userInput =="Chocolate")
            //     //Opening and closing curly braces can be ommitted only if there is 1 line of code after the if statement.
            //         notification = "Here you go!";
            //     else if (userInput == "Vanilla")
            //         notification = "Who takes Vanilla??? Nobody mate, make another order!";
            //     else if (userInput == "Banana")
            //         notification = "Good choice, oga!";
            //     else
            //         notification = "I don't know what you're talking about";
                
                string notification = (userInput == "Strawberry") ? "Coconut" : "Cherry";

                Console.WriteLine("You won a {0} {1}", notification, userInput + " Congratulations");
                Console.ReadLine();
        }

    }
}
