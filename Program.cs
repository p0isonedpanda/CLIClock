using System;
using System.Threading;

namespace CLIClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();

            while (true)
	        {
		        myClock.Tick();
		        Console.WriteLine("Current time: {0}", myClock.CurrentTime);
		        Thread.Sleep(1000); // Sleep for one second
	        }
        }
    }
}
