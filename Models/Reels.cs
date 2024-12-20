using slotMachine.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SlotMachine.Models
{
    public class Reel
    {
        private int symbolIndex; // Store the index of the current symbol
        private Image symbol;
        private readonly PictureBox pictureBox;
        private readonly Theme theme;
        private readonly Random random = new Random();

        public Reel(PictureBox pictureBox, Theme theme)
        {
            this.pictureBox = pictureBox;
            this.theme = theme;
            this.pictureBox.Paint += Reel_Paint;
            this.symbolIndex = random.Next(theme.Symbols.Length);  // Set initial symbol index
            this.symbol = theme.Symbols[symbolIndex]; // Initialize the symbol based on index
        }

        public Image Symbol
        {
            get => symbol;
            set
            {
                symbol = value;
                pictureBox.Invalidate(); // Trigger repaint to update the display
            }
        }

        public int SymbolIndex
        {
            get => symbolIndex;
            set
            {
                symbolIndex = value;
                symbol = theme.Symbols[symbolIndex]; // Get the corresponding image for the index
                pictureBox.Invalidate();
            }
        }

        private void Reel_Paint(object sender, PaintEventArgs e)
        {
            if (symbol != null)
            {
                // Resize the image to fit within the PictureBox dimensions
                int imageWidth = pictureBox.Width;
                int imageHeight = pictureBox.Height;

                // Draw the image resized to fit the PictureBox
                e.Graphics.DrawImage(symbol, new Rectangle(0, 0, imageWidth, imageHeight));
            }
        }

        public void Spin(Reel[] otherReels, int outcomeScenario)
        {
            int newSymbolIndex;

            switch (outcomeScenario)
            {
                case 1: // Loss (40% chance)
                    // Make this reel likely to have a unique symbol
                    do
                    {
                        newSymbolIndex = random.Next(theme.Symbols.Length);
                    } while (IsMatchingSymbolAcrossReels(newSymbolIndex, otherReels));
                    break;

                case 2: // 2 Matches (30% chance)
                    // Make this reel likely to match with one other reel
                    newSymbolIndex = random.Next(theme.Symbols.Length);
                    int matchReelIndex = random.Next(otherReels.Length);
                    while (otherReels[matchReelIndex].symbolIndex == newSymbolIndex)
                    {
                        newSymbolIndex = random.Next(theme.Symbols.Length);
                    }
                    break;

                case 3: // Jackpot (20% chance)
                    // All reels match the same symbol
                    newSymbolIndex = random.Next(theme.Symbols.Length);
                    break;

                default:
                    newSymbolIndex = random.Next(theme.Symbols.Length); // Fallback to random selection
                    break;
            }

            // Set the new symbol for this reel
            symbolIndex = newSymbolIndex;
            symbol = theme.Symbols[symbolIndex];

            // Trigger repaint to show the new symbol
            pictureBox.Invalidate(); // Force a repaint so that the new symbol is displayed
        }

        private bool IsMatchingSymbolAcrossReels(int newSymbolIndex, Reel[] otherReels)
        {
            // Check if the new symbol matches any other reel's current symbol
            foreach (var reel in otherReels)
            {
                if (reel.symbolIndex == newSymbolIndex)
                {
                    return true; // A match was found, so we will retry selecting a different symbol
                }
            }

            // No match was found, the symbol is unique
            return false;
        }


        }
}
