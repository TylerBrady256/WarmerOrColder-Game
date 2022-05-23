namespace Seeker{


    public class Seeker
    {
            private int GuessLocation;

            public int Distance;
            public void GetLocation(int location)
            {      
                this.Distance = Math.Abs(location - this.GuessLocation);
            }
            
            public void MoveLocation(int NewLocation)
            {
                this.GuessLocation = NewLocation;
            }



    }
}