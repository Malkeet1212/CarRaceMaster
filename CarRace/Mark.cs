using System.Windows.Forms;


namespace CarRace
{
    using System;

    public class Mark : Racer
    {
        public Mark(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setRacerName()
        {
            Name = "Mark";
        }
    }
}