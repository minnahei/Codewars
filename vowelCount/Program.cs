using System;

namespace vowelCount
{
    class Program
    {
        public static int VowelCount(string str)
        {
            int vowelCount = 0;

            char[] letters = str.ToCharArray();

            foreach (char c in letters)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
