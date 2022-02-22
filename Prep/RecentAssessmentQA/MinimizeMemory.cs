using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep.RecentAssessmentQA
{
    public class MinimizeMemory
    {
        /* The virtual private server on Amazon's Web service cloud is used to run programs that help perform calculations
         * on large data sets. Recently, the performacne of some programs has degraded.
         * Technical support has recommended that process that consume a lot of main memory should be deleted. 
         * Unfortunately, the command-line shell that you use only lets you delete processes that form a single
         * contiguous segment is that number of conitguous processes n main memory.
         * Find the minimum amount of main memory used by all of your processes in your instance after you delete a contiguous
         * segment of processes.
         * 
         * Example: process= [10,4,8,13,20] m=2
         * OP: 9
         */
        public static int minimizeMemory(int[] segments, int m)
        {
            int total = 0, max, windowSum = 0;

            foreach (int segment in segments)
            {
                total += segment;
            }

            for (int i = 0; i < m; i++)
            {
                windowSum += segments[i];
            }

            max = windowSum;


            for (int i = m; i < segments.Length; i++)
            {
                windowSum -= segments[i - m];
                windowSum += segments[i];

                max = Math.Max(max, windowSum);
            }

            return total - max;
        }

        /* Given an array of stock prices, find the month at which the net price change is minimum
         * If there are several such months, return the earliest month.
         * Note: The average of a set of integers here is defined as the sum of integers
         * divided by the number of integers, rounded down to the nearest integer.
         * For example, the average of [1,2,3,4] is the floor if (1+2+3+4)/4=2.5
         * and the floor of 2.5 is 2.
         * Ex: prices = [1,3,2,3]
         * Returns: int: the earliest month in which the net price change is minimum
         */
        public static int stockPrices(int[] prices)
        {
            int n = prices.Length, minAverage = Int32.MaxValue, rightSum = 0, month = 0;

            foreach (int price in prices)
            {
                rightSum += price;
            }

            int leftSum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                leftSum += prices[i];
                rightSum -= prices[i];

                int leftAverage = leftSum / (i + 1);
                int rightAverage = rightSum / (n - i - 1);


                int diff = Math.Abs(leftAverage - rightAverage);

                if (diff < minAverage)
                {
                    minAverage = diff;
                    month = i + 1;
                }
            }


            return month;
        }

        /*
         * Amazon Prime games is designing a game. The player needs to pass n rounds sequentially
         * in this game, Rules of play are as follows:
         * 
         * The player loses power[i[ health to complete round i.
         * The player's health must be greater than 0 at all times.
         * The player can choose to use armour in any one round.
         * The armour will prevent damage of min(armor, power[i])
         * ** Determine the minimum starting health for a player to win the game
         * 
         * Example:input:  power = [1,2,6,7] armor = 5
         * Output lnog integer
         */
        public static int FindMinHealth(int[] power, int armor)
        {
            int max = 0;
            foreach (int v in power)
                max += v;
            int s = 0;
            int e = max;
            int ans = Int32.MaxValue;
            while (s <= e)
            {
                int mid = (s + e) / 2;
                if (check(power, mid, armor))
                {
                    ans = Math.Min(ans, mid);
                    e = mid - 1;
                }
                else
                {
                    s = mid + 1;
                }
            }
            return ans;
        }
        public static bool check(int[] power, int m, int am)
        {
            for (int i = 0; i < power.Length; i++)
            {
                if (m - power[i] > 0)
                {
                    m = m - power[i];
                }
                else
                {
                    if (m - power[i] + am > 0)
                    {
                        m = m - power[i] + am;
                        am = 0;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (m > 0) return true;
            else return false;
        }

    }
}
