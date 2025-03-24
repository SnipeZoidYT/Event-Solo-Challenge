using System.Diagnostics;

namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initilizing the varables
            string[] activities = {"walking", "cycling", "running"};
            bool isValidGroup = false;
            bool isValidTime = false;
            bool isValidActivity = false;
            int group;
            int time;
            double cost = 0;
            double total = 0;
            const double discount = 10;

            // A while loop that continues until the user enters a valid activity or set of activities
            while (!isValidActivity)
            {
                // Asking the user what event they would like to do
                Console.WriteLine("What event would you like to do?(choose activities spaced by commas)");
                Console.WriteLine("1. Walking");
                Console.WriteLine("2. Cycling");
                Console.WriteLine("3. Running");
                Console.Write(": ");

                // Getting the users input and storing it
                string input = Console.ReadLine().ToLower();
                // Split the user's input by commas to handle multiple activities
                activities = input.Split(',');

                // A for each loop that goes thrugh the activities
                foreach (string activity in activities)
                {
                    // A switch statement that checks the activity and updates the cost accordingly
                    switch (activity.Trim())
                    {
                        case "walking":
                            
                            isValidActivity = true;
                            cost = cost + 1.5;
                            break;
                        case "cycling":
                          
                            isValidActivity = true;
                            cost = cost + 2.5;
                            break;
                        case "running":
                         
                            isValidActivity = true;
                            cost = cost + 2.25;
                            break;
                        default:
                            Console.WriteLine("Enter a valid activity!");
                            break;
                    }
                }
            }
            // A while loop that continues until the user enters a valid age group
            while (!isValidGroup)
            {
                // Asking the user what age range they are in
                Console.WriteLine("\nWhat age range do you come under?");
                Console.WriteLine("1. Junior (5 - 17)");
                Console.WriteLine("2. Senior (66 - 80)");
                Console.WriteLine("3. Adult (18 - 65)");
                Console.Write(": ");

                // Setting the users age range to the varable group
                group = int.Parse(Console.ReadLine());

                // A switch statement that checks the age group and updates the cost accordingly
                switch (group)
                {
                    case 1:
                        Console.WriteLine("You are a Junior");
                        isValidGroup = true;
                        cost = cost + 10;
                        break;
                    case 2:
                        Console.WriteLine("You are a Senior");
                        isValidGroup = true;
                        cost = cost + 7;
                        break;
                    case 3:
                        Console.WriteLine("You are a Adult");
                        isValidGroup = true;
                        cost = cost + 15;
                        break;
                    default:
                        Console.WriteLine("Enter a valid group");
                        break;
                }
            }

            // A while loop that checks if the entered time is valid
            while (!isValidTime)
                {
                    // Asking the user how long they would like to do the event for
                    Console.WriteLine("How long would you like to do the event for?");
                    Console.WriteLine("1. Half a day");
                    Console.WriteLine("2. Day");
                    Console.WriteLine("3. Week");
                    Console.Write(": ");

                    // Setting how long the user wants to do the event for to the varable time
                    time = int.Parse(Console.ReadLine());

                    // A switch statement that determins the cost based on the users input
                    switch (time)
                    {
                        case 1:
                            Console.WriteLine("You have selected half a day");
                            cost = cost * 0.5;
                            isValidTime = true;
                            break;
                        case 2:
                            Console.WriteLine("You have selected a day");
                            cost = cost * 1;
                            isValidTime = true;
                            break;
                        case 3:
                            Console.WriteLine("You have selected a week");
                            cost = cost * 7;
                            isValidTime = true;
                            break;
                        default:
                            Console.WriteLine("Enter a valid amount of time");
                            break;
                    }
                }
                Console.WriteLine(" --------------------------");
                Console.WriteLine($"|Your subtotal is £{cost:F2}  |");
                Console.WriteLine(" --------------------------");


                // An if statement that applies a discount if the total cost is greater than £30
                if (cost > 30)
                {
                    Console.WriteLine("\nYou have been awarded a discount");
                    total = cost / 100 * discount;
                    total = cost - total;

                }
                else
                {
                    Console.WriteLine($"You have not been awarded a discout as your cost is {cost} and it ahs to be more than £30");
                    total = cost;
                }

                // Telling the user thier total
                Console.WriteLine(" ------------------------");
                Console.WriteLine($"|Your total is £{total:F2}   |");
                Console.WriteLine(" ------------------------");

                // Prompt the user to press any key to exit the program
                Console.WriteLine("Press any key to exit......");
                Console.ReadKey();
        }
    }
}
