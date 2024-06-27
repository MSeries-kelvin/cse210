// Exceeding Requirement: As a stretch challenge, I randomly select from 
// only those words that are not already hidden.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference myReference = new Reference("Ecclesiastes", 4, 1, 5);

        Scripture myScripture = new Scripture(myReference, "Again I turned my attention to all the acts of oppression that go on under the sun. I saw the tears of the oppressed, and there was no one to comfort them. And their oppressors had the power, and there was no one to comfort them. And I congratulated the dead who had already died rather than the living who were still alive. And better off than both of them is the one who has not yet been born, who has not seen the distressing deeds that are done under the sun. And I have seen how much effort and skillful work spring from rivalry between people; this too is futility, a chasing after the wind. The stupid one folds his hands while his flesh wastes away.");

        Console.WriteLine(myScripture.GetDisplayText());

        while (true)
        {
            if (myScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(myScripture.GetDisplayText());
                break;
            }
            
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type \"quit\" to finish");
            Console.Write(">> ");
            string option = Console.ReadLine();

            if (option == "quit")
            {
                break;
            }

            myScripture.HideRandomWords(5);
        }

    }
}