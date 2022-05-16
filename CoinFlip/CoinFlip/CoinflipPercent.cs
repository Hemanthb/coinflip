using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    internal class CoinflipPercent
    {
        int numOfTimes;
        int tailsCount=0;
        int headsCount=0;
        double tailsPercent;
        double headsPercent;
        public void GetNumOfTimes()
        {
            Console.WriteLine("Enter the number of times to toss coin");
            numOfTimes = Convert.ToInt32(Console.ReadLine());
        }
        public void CalculatePercentage()
        {
            Random random = new Random();
            for(int i = 0; i < numOfTimes; i++)
            {
                double choice = random.NextDouble();
                
                if(choice > 0.5)
                {
                    tailsCount = tailsCount + 1;
                    //Console.WriteLine(tailsCount);
                }
                else
                {
                    headsCount = headsCount + 1;
                }

            }
            tailsPercent = (tailsCount*100)/numOfTimes;
            headsPercent = (headsCount*100)/numOfTimes;
            
        }
        public void displayPercent()
        {
            Console.WriteLine("Percentage of tails is" + tailsPercent+"%");
            Console.WriteLine("Percentage of Heads is" + headsPercent+"%");
        }
    }
}
