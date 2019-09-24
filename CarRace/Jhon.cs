using System.Windows.Forms;

namespace CarRace
{
    using System;

    public class Jhon : Racer
    {
        public Jhon(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setRacerName()
        {
            Name = "Jhon";
        }
    }
}