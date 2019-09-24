using System;
using System.Windows.Forms;

namespace CarRace {
    public partial class Form1 : Form {
        Cars[] Carss = new Cars[4];

        RacerFactory pFactory = new RacerFactory();
        Racer[] Racers = new Racer[3];

        public Form1() {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack() {
            
            Cars.StartingPosition1 = Car1.Right - racetrack.Left; 
            Cars.RacetrackLength1 = racetrack.Size.Width - 70 ; //fixing length of race - till finish line
                
            Carss[0] = new Cars() { CarsPictureBox = Car1};
            Carss[1] = new Cars() { CarsPictureBox = Car2};
            Carss[2] = new Cars() { CarsPictureBox = Car3};
            Carss[3] = new Cars() { CarsPictureBox = Car4};

            Racers[0] = pFactory.getRacer("Jhon",MaximumBet,JhonBet); //getting Jhon object from factory class
            Racers[1] = pFactory.getRacer("Mark", MaximumBet, MarkBet); //getting Mark object from factory class
            Racers[2] = pFactory.getRacer("Lim", MaximumBet, LimBet); //getting Lim object from factory class


            foreach (Racer Racer in Racers) {
                Racer.UpdateLabels();
            }
        }

        private void JhonButton_CheckedChanged(object sender, EventArgs e) {
            setMaximumBetTextLabel(Racers[0].Cash);
        }

        private void MarkButton_CheckedChanged(object sender, EventArgs e) {
            setMaximumBetTextLabel(Racers[1].Cash);
        }

        private void LimButton_CheckedChanged(object sender, EventArgs e) {
            setMaximumBetTextLabel(Racers[2].Cash);
        }

        private void setMaximumBetTextLabel(int Cash) {
            MaximumBet.Text= String.Format("Maximum Bet: ${0}", Cash);
        }

        // setting the bet for each Racer and updating labels respectively
        private void Bets_Click(object sender, EventArgs e) {
            int RacerNum = 0;

            if (JhonButton.Checked) {
                RacerNum = 0;
            }
            if (MarkRButton.Checked) {
                RacerNum = 1;
            }
            if (LimRButton.Checked) {
                RacerNum = 2;
            }

            Racers[RacerNum].PlaceBet((int)carRaceAmount.Value, (int)CarsNumber.Value);
            Racers[RacerNum].UpdateLabels();
        }

        private void race_Click(object sender, EventArgs e) {
            bool NoWinner = true;
            int winningCars;
            race.Enabled = false; //disable start race button

            while (NoWinner) { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Carss.Length; i++ ) {
                    if (Cars.Run(Carss[i])) { 
                        winningCars = i + 1;
                        NoWinner = false;
                        MessageBox.Show("winner of the race is - Cars #" + winningCars);
                        foreach (Racer Racer in Racers) {
                            if (Racer.bet != null) {
                                Racer.Collect(winningCars); //give double amount to all who've won or deduce betted amount
                                Racer.bet = null; 
                                Racer.UpdateLabels();
                            }
                        }
                        foreach (Cars Cars in Carss) {
                            Cars.TakeStartingPosition();
                        }
                        break;
                    }                    
                }                
            }
            if (Racers[0].busted && Racers[1].busted && Racers[2].busted){  //stop Racers from betting if they run out of cash
                String message = "Do you want to Play Again?";
                String title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes) {
                    SetupRaceTrack(); //restart game
                }
                else {
                    this.Close();  
                }

            }
            race.Enabled = true; //enable race button 
        }

        private void Racetrack_Click(object sender, EventArgs e)
        {

        }

        private void carRaceAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MaximumBet_Click(object sender, EventArgs e)
        {

        }

        private void CarsNumber_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
