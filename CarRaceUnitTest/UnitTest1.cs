using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRace;
namespace CarRaceTest
{
    [TestClass]
    public class UnitTest1
    {
        RacerFactory pFactory = new RacerFactory();
        Racer Lim;
        Cars[] Carss = new Cars[2];
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestWinnerOutcome()
        {
            Cars.StartingPosition1 = 0;
            Cars.RacetrackLength1 = 50;
            int carRaceAmount = 45;
            int CarsNumber = 2;
            int expectedWin = 90;
            int expectedLose = 0;
            Carss[0] = new Cars() { CarsPictureBox = null };
            Carss[1] = new Cars() { CarsPictureBox = null };
            Lim = pFactory.getRacer("Lim", null, null);
            Lim.Cash = carRaceAmount;
            Lim.PlaceBet((int)carRaceAmount, CarsNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Carss.Length; i++)
                {
                    if (Cars.Run(Carss[i]))
                    {
                        win = i + 1;
                        Lim.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Lim.bet.carNum == win)
            {
                Assert.AreEqual(expectedWin, Lim.Cash, "Account not credited correctly");
            }
            if (Lim.bet.carNum != win)
            {
                Assert.AreEqual(expectedLose, Lim.Cash, "Account not debited correctly");

            }
        }
    }

}
