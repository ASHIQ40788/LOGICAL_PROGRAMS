using System;
using System.Diagnostics;
using System.Threading;

namespace LOGICAL_PROGRAMS
{

	class STOP_WATCH
	{
		public void stopwatch()
		{
			// Create new stopwatch
			Stopwatch stopwat = new Stopwatch();

			// Begin timing
			stopwat.Start();

			// Do something
			for (int i = 0; i < 1000; i++)
			{
				Thread.Sleep(1);
			}

			// Stop timing
			stopwat.Stop();

			// Write result
			Console.WriteLine("Time elapsed: {0}", stopwat.Elapsed);

			Console.ReadKey();
		}
	}
}