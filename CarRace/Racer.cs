using System;
using System.Windows.Forms;

namespace CarRace
{
    public abstract class Racer {
        public string Name;
        public Bet bet;
        public int Cash;
        public bool busted;
        public Label statusLabel,MaximumBet;
        
        public Racer(Bet bet, Label MaximumBet,int Cash, Label statusLabel) {
            this.bet = bet;
            this.Cash = Cash;
            this.MaximumBet = MaximumBet;
            this.statusLabel = statusLabel;
            if (this.statusLabel != null)
                this.statusLabel.ForeColor = System.Drawing.Color.Black;

        }

        public void UpdateLabels() {
            if (bet == null) {
                statusLabel.Text = String.Format("{0} hasn't placed any bets", Name);
            }
            
                else {
                statusLabel.Text = bet.GetDescription();
            }
            if(Cash == 0){
                busted = true;
                statusLabel.Text = String.Format("BUSTED!");
                statusLabel.ForeColor = System.Drawing.Color.Red;

            }
            MaximumBet.Text = String.Format("Maximum Bet: ${0}", Cash);
        }


        public void ClearBet() {
            bet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int cars) {
            if (Amount <= Cash) {
                bet = new Bet(Amount, cars, this);
                return true;
            }
            return false;
        }

        public void Collect(int Winner) {
            Cash += bet.Pay(Winner);
        }

        public abstract void setRacerName();
    }
}
