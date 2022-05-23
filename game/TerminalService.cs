using System;

namespace Seeker
{

    public class TerminalService
    {
        public static int ReadNumber(string UserGuess="1")
        {
            return int.Parse(UserGuess); //Converts the string to an int.
        }


        public void WriteText(string TextToBeRead)
        {
            Console.WriteLine(TextToBeRead);  
        }


    }

}