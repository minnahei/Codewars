using System;
using System.Collections.Generic;

namespace ParityOutlier
{
    class Program
    {
        public static int Find(int[] integers)
        {
            var oddInts = new List<int>();
            var evenInts = new List<int>();

            foreach (int num in integers)
            {
                if (num % 2 == 0)
                {
                    evenInts.Add(num);
                }
                else
                {
                    oddInts.Add(num);
                }
            }

            if (oddInts.Count > evenInts.Count)
            {
                return evenInts[0];
            }
            else
            {
                return oddInts[0];
            }
        }
    }
}
