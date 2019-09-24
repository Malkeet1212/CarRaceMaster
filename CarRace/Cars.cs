using System;
using System.Windows.Forms;
using System.Drawing;

namespace CarRace
{
    public class Cars
    {
        private static int StartingPosition;
        private static int RacetrackLength;
        public PictureBox CarsPictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int RacetrackLength1 { get => RacetrackLength; set => RacetrackLength = value; }

        // generation across all Cars objects

        public static bool Run(Cars obj)
        {
            int distance = MyRandom.Next(2, 6);
            if (obj.CarsPictureBox != null)
                obj.MoveCarsPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            MoveCarsPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveCarsPictureBox(int distance)
        {
            Point p = CarsPictureBox.Location;
            p.X += distance;
            CarsPictureBox.Location = p; //move Cars in x-axis
        }
    }
}
