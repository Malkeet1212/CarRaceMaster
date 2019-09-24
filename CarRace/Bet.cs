using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRace
{
    // this coding is for bet class
    public class Bet
    {
        public int Amount;
        public int carNum;
        public Racer Bettor;

        public Bet(int Amount, int carNum, Racer Bettor)
        {
            this.Amount = Amount;
            this.carNum = carNum;
            this.Bettor = Bettor;
        }
        // this coding is for description
        public string GetDescription()
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets {1} on Car #{2}",
                    Bettor.Name, Amount, carNum);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets",
                    Bettor.Name);
            }
            return description;
        }
        //this coding is for winner class

        public int Pay(int Winner)
        {
            if (carNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
