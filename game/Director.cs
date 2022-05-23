using System;

namespace Seeker
{
    class Director{
       
         Hider hider = new Hider();
         Seeker seeker = new Seeker();
         public int GuessedLocation;
         private int location;
         public bool KeepPlaying =true;
        public void StartGame()
        {
            
            this.location = hider.SetLocation();
            
            TerminalService terminalService = new TerminalService();
            

            while (KeepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }

        }

        public void GetInputs()
        {
        Console.WriteLine("Guess a location for 1-1000");

        try
        {string UserInput = Console.ReadLine();
        this.GuessedLocation = TerminalService.ReadNumber(UserInput);
        }
        catch
        {string UserInput ="100";
        Console.WriteLine(UserInput);
        this.GuessedLocation = TerminalService.ReadNumber(UserInput);};
        }

        public void DoUpdates()
        {
            seeker.MoveLocation(this.GuessedLocation);
            seeker.GetLocation(this.location);
        }

        public void DoOutputs()
        {   
            this.KeepPlaying = hider.IsFound(seeker.Distance);
        }


    }

}