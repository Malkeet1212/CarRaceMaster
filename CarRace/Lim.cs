using System.Windows.Forms;

namespace CarRace
{
    public class Lim : Racer
    {
        public Lim(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setRacerName()
        {
            Name = "Lim";
        }
    }
}