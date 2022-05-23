using System;

namespace Seeker
{
    public class Hider
    {
        Random random = new Random();
        private int location;
        private int Distance;
        private int PreviousGuessDistance=1000;
        public int SetLocation()
        {
        return random.Next(1000);  // selects a random int value that the user will have to guess
        }

        public bool IsFound(int Distance) // checks to see if the difference between your previous guess and your current guess is negative or positive for hot or cold or if it is equal to zero.
        {
            TerminalService terminal = new TerminalService();
            if (Distance == 0)
                {
                    string line = "you have won the game";
                    terminal.WriteText(line);
                    return false;

                }
                else if(Distance<PreviousGuessDistance)
                {
                    string line = "You're Getting Warmer";
                    terminal.WriteText(line);
                }
                else if (Distance>PreviousGuessDistance)
                {
                    string line = "You're Getting COLDER";
                    terminal.WriteText(line);
                }
                PreviousGuessDistance = Distance;  
                return true;
            
        }
    }

}