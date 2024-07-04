// Exceeding Requirements: I add a LogKeeper class
// that Keeping a log of how many times activities were performed
// and display that to the user right before they quit the program.

using System;

class Program
{
    static void Main(string[] args)
    {
        int option;
        LogKeeper logKeeper = new LogKeeper();

        string menu = "Menu Options:\n    1. Start breathing activity\n    2. Start reflecting activity\n    3. Start listing activty\n    4. Quit\nSelect a choice from the menu: ";

        do
        {
            Console.Write(menu);
            option = int.Parse(Console.ReadLine());
            Console.Clear();

            if (option == 1)
            {
                BreathingActivity activity = new BreathingActivity("Breathing Acitivity", "This activity will help you relax by working your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                activity.Run();
                logKeeper.Add();
                Console.Clear();
            }
            else if (option == 2)
            {
                ReflectingActivity activity = new ReflectingActivity("Reflecting Acitivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity.Run();
                logKeeper.Add();
                Console.Clear();
            }
            else if (option == 3)
            {
                ListingActivity activity = new ListingActivity("Listing Acitivity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity.Run();
                logKeeper.Add();
                Console.Clear();
            }
            else if (option == 4)
            {
                logKeeper.ShowLog();
                break;
            }

        } while (option != 4);
    }
}