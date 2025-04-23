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
         
            
        }

        // Method to play a voice greeting

        static void PlayVoiceGreeting()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Chat_bot_greeting);
            player.Play();
        }

        // Method to display ASCII art
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(asciiArt);
            Console.ResetColor();
        }

       
    }
}


