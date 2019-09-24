using System;
using System.Windows.Forms;
using System.Drawing;

namespace BettingCounter {
    public class Horse {
        private static int StartingPosition;
        private static int RacetrackLength;
        public PictureBox HorsePictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int RacetrackLength1 { get => RacetrackLength; set => RacetrackLength = value; }

        // generation across all horse objects

        public static bool Run(Horse obj) {
            int distance = MyRandom.Next(2, 6);
            if (obj.HorsePictureBox != null)
            obj.MoveHorsePictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1)) {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition() {
            MoveHorsePictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveHorsePictureBox(int distance) {
            Point p = HorsePictureBox.Location;
            p.X += distance;  
            HorsePictureBox.Location = p; //move horse in x-axis
        }
    }
}
