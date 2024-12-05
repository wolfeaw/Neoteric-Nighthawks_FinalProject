/*
# Name: Drew Wolfe
# email: wolfeaw@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Semester 1, Year 4
# Brief Description: This project completes a leetcode problem and collaborates with other team members to do the same
# Citations: n/a
# Anything else that's relevant: n/a
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Neoteric_Nighthawks_FinalProject
{
    public class wolfeaw
    {
        public int MaxSatisfaction(int[] satisfaction)
        {
            Array.Sort(satisfaction);
            Array.Reverse(satisfaction);

            int maxSatisfaction = 0;
            int currentSum = 0;
            int total = 0;

            foreach (int sat in satisfaction)
            {
                total += sat;
                if (total > 0)
                {
                    currentSum += total;
                    maxSatisfaction = currentSum;
                }
                else
                {
                    break;
                }
            }

            return maxSatisfaction;
        }
    }
}
