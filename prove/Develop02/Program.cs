using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = "Please select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit";
        int option;

        Journal newJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");
        
        do
        {   
            Console.WriteLine(menu);
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                string promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(promptText);
                Console.Write(">");

                string entryText = Console.ReadLine();

                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();

                Entry entry = new Entry(dateText, promptText, entryText);

                newJournal.AddEntry(entry);
            }
            else if (option == 2)
            {
                newJournal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.WriteLine("Enter a file name:");
                string filename = Console.ReadLine();

                newJournal.LoadFromFile(filename);
            }
            else if (option == 4)
            {
                Console.WriteLine("Enter a file name:");
                string filename = Console.ReadLine();

                newJournal.SaveToFile(filename);
            }
            else
            {
                break;
            }
        } while (option != 5);
    }
}