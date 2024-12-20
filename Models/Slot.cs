using slotMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;

        public Slot(int initialBalance, PictureBox[] pictureBoxes, Theme theme)
        {
            this.balance = initialBalance;
            this.reels = new Reel[pictureBoxes.Length];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                reels[i] = new Reel(pictureBoxes[i], theme);
            }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Stake
        {
            get { return stake; }
            set { stake = value; }
        }

        public void Spin()
        {
            // Simulate the outcome based on probability distribution
            int outcomeScenario = GetOutcomeScenario();

            // Spin each reel, passing the outcome scenario to influence symbol selection
            for (int i = 0; i < reels.Length; i++)
            {
                // Pass the other reels to each reel's Spin method
                Reel[] otherReels = reels.Where((r, index) => index != i).ToArray();
                reels[i].Spin(otherReels, outcomeScenario);
            }
        }

        private int GetOutcomeScenario()
        {
            // Randomly choose an outcome scenario based on desired probabilities
            var random= new Random();
            int roll = random.Next(100);
            if (roll < 40) // 40% chance of loss
            {
                return 1; // Loss
            }
            else if (roll < 70) // 30% chance of 2 matches
            {
                return 2; // 2 Matches
            }
            else // 20% chance of jackpot
            {
                return 3; // Jackpot
            }
        }



        public int CheckResult()
        {
            int winnings = 0;
            //int multiplier = 0;

            // Compare the symbol indices to check for matches
            if (reels[0].SymbolIndex == reels[1].SymbolIndex && reels[1].SymbolIndex == reels[2].SymbolIndex)
            {
                //multiplier = 10; // Jackpot multiplier
                //winnings = stake * multiplier;
                winnings = stake * 10;
            }
            // Check if two symbols match (partial match)
             else if (reels[0].SymbolIndex == reels[1].SymbolIndex ||
                       reels[1].SymbolIndex == reels[2].SymbolIndex ||
                       reels[0].SymbolIndex == reels[2].SymbolIndex)
              {
                // multiplier = 2; // Partial match multiplier
                //winnings = stake * multiplier;
                winnings = stake * 2;
              }
            else { winnings= 0; }

            return (winnings);
        }



        public void UpdateBalance(int winnings)
        {
            Balance += winnings;
        }
    }
}
