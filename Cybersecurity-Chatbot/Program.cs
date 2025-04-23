using System;
using System.Threading;
using System.Media;

namespace Cybersecurity_Chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayVoiceGreeting();
            AsciiArt();
            string userName = UserName();
            WelcomeMessage(userName);
            InformationSystem(userName);
        }
        //Method to change text colour adapted from GeeksForGeeks "C# | How to change Foreground Color of Text in Console": https://www.geeksforgeeks.org/c-sharp-how-to-change-foreground-color-of-text-in-console/ by "GeeksForGeeks", accessed on 4/23/2024

        // Method to play a voice greeting
        // Voice greeting method adapted from "Intro to C# Visual Studio - Adding Audio to your Programs": https://www.youtube.com/watch?v=O_-C2F8K2KI by Room 212, acsessed on 4/23/2024

        static void PlayVoiceGreeting()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Chat_bot_greeting);
            player.Play();
        }

        // Method to display ASCII art
        // ASCII title "Cyber Safety" created using an online ASCII generator: https://patorjk.com/software/taag/#p=display&f=ANSI%20Shadow&t=%0A%7CCyber%20Safety%7C%0A%7C%20%20%20%20%20%20%20%20%20%20%20%20%7C%0A%5C%0A%20%5C
        // Code on how to display ASCII art found/adapted from "stackoverflow Producing ascii art via C#" https://stackoverflow.com/questions/3436132/producing-ascii-art-via-c-sharp by user "YT_GraphiX", accessed on 4/23/2024
        static void AsciiArt()
        {
            string asciiArt = @"
  ██████╗██╗   ██╗██████╗ ███████╗██████╗     ███████╗ █████╗ ███████╗███████╗████████╗██╗   ██╗
██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔════╝██╔══██╗██╔════╝██╔════╝╚══██╔══╝╚██╗ ██╔╝
██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ███████╗███████║█████╗  █████╗     ██║    ╚████╔╝ 
██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ╚════██║██╔══██║██╔══╝  ██╔══╝     ██║     ╚██╔╝  
╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ███████║██║  ██║██║     ███████╗   ██║      ██║   
 ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚══════╝╚═╝  ╚═╝╚═╝     ╚══════╝   ╚═╝      ╚═╝                                                                                            
                                   _______________________
                                  ||                     ||
                                  ||                     ||
                                  ||                     ||
                                  ||                     ||
                                   \\                   //
                                    \\                 //
                                     \\               //
                                      \\             //
                                       \\           //
                                        \\         //
                                         \\       //
                                          \\     //  
                                           \\   //
                                            \\ //
                                             \V/
         

                            >>> Cybersecurity Awareness Bot <<<
";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(asciiArt);
            Console.ResetColor();
        }

        // Method to record user name
        static string UserName()
        {
            Console.Write("Please enter your user name. ");
            string name = Console.ReadLine();
            return name;
        }

        // Method to display a welcome message
        static void WelcomeMessage(string name)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeText($"\nHello, {name}! This application will be used to teach you about Cyber security.\n");
            Console.ResetColor();
        }

        // Method to provide information based on user input
        // Method uses a loop to keep asking for input until a valid response is given
        // Method is based on code from "stackoverflow How can I loop and check for correct user input in C#?": https://stackoverflow.com/questions/20368365/how-can-i-loop-and-check-for-correct-user-input-in-c by "user3029538" accessed on 4/23/2024
        static void InformationSystem(string name)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{name}: ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Your input is invalid. Please try again");
                }
                else if (input == "What can I ask you?")
                {
                    Console.WriteLine("Here is a list of available questions that you may ask: .");
                    Console.WriteLine("1. what is phishing? ");
                    Console.WriteLine("2. How can I stay safe from phishing? ");
                    Console.WriteLine("3. cyber security tips");
                    Console.WriteLine("4. Give me tips on safe browsing");
                    Console.WriteLine("5. How are you?");
                }
                else if (input == "what is phishing?")
                {
                    Console.WriteLine("Phishing is a type of cyber-attack that aims to trick you into revealing sensitive information (e.g. banking info), through the use of constant spam");
                }
                else if (input == "How can I stay safe from phishing?")
                {
                    Console.WriteLine("There are various ways in which you can stay safe from phishing. ");
                    Console.WriteLine(" 1.Ensure that all security systems are up to date and properly in place (this inckudes system software and fire walls.)");
                    Console.WriteLine(" 2. Be cautious and avoid opening suspecious links or emails.");
                    Console.WriteLine(" 3. Avoid clicking on pop-ups and malicious sites.");
                    Console.WriteLine(" 4. Be cautious when disclosing personal information.");
                }
                else if (input == "cyber security tips")
                {
                    Console.WriteLine("Sure" + name + "Here are some tips:");
                    Console.WriteLine("1. Use a strong password and implement two factor authentication.");
                    Console.WriteLine("2. Keep your software and operating system up to date.");
                    Console.WriteLine("3. Back up any important data.");
                    Console.WriteLine("4. Be cautious when using public Wi-Fi and external devices.");
                }
                else if (input == "Give me tips on safe browsimg")
                {
                    Console.WriteLine("Avoid suspicious sites and ensure that your connection is secure");
                }
                else if (input == "How are you")
                {
                    Console.WriteLine("I'm quite well, how are you?");
                }
                else
                {
                    Console.WriteLine("Question is not valid, please select a valid question");
                }
            }
        }

        // Method to type text with a delay
        // Method created with the assitance of Github copilot
        static void TypeText(string text, int delay = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}
       
    



