using System;
using System.Windows.Forms;

namespace CarRace
{
    //coding is for racer factory
    public class RacerFactory
    {
        public Racer getRacer(String Name, Label MaximumBet, Label bet)
        {
            Racer p;
            switch (Name.ToLower())
            {
                case "jhon":
                    p = new Jhon(null, MaximumBet, 50, bet);
                    break;

                case "mark":
                    p = new Mark(null, MaximumBet, 50, bet);
                    break;

                case "lim":
                    p = new Lim(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setRacerName();
            return p;
        }
    }
}