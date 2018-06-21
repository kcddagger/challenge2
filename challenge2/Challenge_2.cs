using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    class Challenge_2
    {
        static void Main(string[] args)
        {
            string n;

            Console.WriteLine("Enter the duration of your ride in minutes. It is guaranteed you have been riding less than a day (24 hours).");
            n = Console.ReadLine();

            lateRide(n);
        }

        private static void lateRide(string n)
        {
            DateTime rideStart = new DateTime();
            int m;
            int.TryParse(n, out m);
            TimeSpan rideLength = new TimeSpan(00, m, 00);
            DateTime currentTime = new DateTime();

            currentTime = rideStart.Add(rideLength);
            string strCurrentTime = String.Format("{0:HHmmss}", currentTime);
            int timeTotal = 0;

            foreach (char c in strCurrentTime)
            {
                timeTotal += int.Parse(c.ToString());
            }

            Console.WriteLine(timeTotal);
            Console.ReadLine();
        }
    }
}
