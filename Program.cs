using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm run = new Algorithm();

            int n = 8;
            string s = "UDDDUDUU"; 

            int result = run.CountingValleys(n, s);

            Console.WriteLine("Expected: {0}", 1);
            Console.WriteLine("Actual: {0}", result);

        }
    }

    class Algorithm
    {
        public int CountingValleys(int n, string s)
        {
            int elevation = 0;
            int[] altitude = new int[n];
            int valleyCounter = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    elevation++;
                    altitude[i] = elevation;
                }
                if (s[i] == 'D')
                {
                    elevation--;
                    altitude[i] = elevation;
                }
            }


            if (altitude[0] == -1)
            {
                valleyCounter++;
            }

            int num = 1;

            while (num < n - 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (altitude[i] == 0 && altitude[num] == -1)
                    {
                        valleyCounter++;
                    }
                    num++;
                }
            }

            return valleyCounter;
        }
    }
}
