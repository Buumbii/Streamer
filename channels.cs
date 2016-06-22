using System;
using System.Diagnostics;
namespace Streamer
{
	public class channels
	{

		public static void SwitchChannels ()
		{
			Boolean willcontinue = true;
			int nav;
			ProcessStartInfo startInfo = new ProcessStartInfo ();
			Process proc = new Process();



			nav = 0;
			

			while (willcontinue) {
				
				switch (nav) {

				case 0: 

					Console.WriteLine ("------------------\n" +
						"Channel 1: GoG\n" +
						"Channel 2: GoL\n" +
						"Channel 3: Test\n" +
						"Channel 4: Swify\n"+
						"Exit Program 9:\n" +
						"------------------");
					nav = Convert.ToInt32 (Console.ReadLine ());

				break;
				
				
				case 1:
					Console.WriteLine ("Open GoG Channel");
					//väntar få de se ut som den tänker.s
					startInfo = new ProcessStartInfo () {FileName = "/bin/bash",
						Arguments = "/home/niclas/Documents/Streamer/Streamer/channels/gog.bat",
					};
					proc = new Process { StartInfo = startInfo, };
					proc.Start ();
					nav = Convert.ToInt32 (Console.ReadLine ());
	
					break;

				case 2:
					Console.WriteLine ("Open GamingOnLinux");
					//väntar få de se ut som den tänker.
					startInfo = new ProcessStartInfo () {
						FileName = "/bin/bash",
						Arguments = "/home/niclas/Documents/Streamer/Streamer/channels/gol.bat",}; 
					proc = new Process { StartInfo = startInfo, };
					proc.Start ();
					nav = Convert.ToInt32 (Console.ReadLine ());
					break;

				case 3:

					//väntar få de se ut som den tänker.
					startInfo = new ProcessStartInfo () {
						FileName = "/bin/bash",
						Arguments = "/home/niclas/Documents/Streamer/Streamer/channels/test.bat",};
					proc = new Process { StartInfo = startInfo, };
					proc.Start ();
					nav = Convert.ToInt32 (Console.ReadLine ());
					break;


				case 4:
					//väntar få de se ut som den tänker.
					startInfo = new ProcessStartInfo () {
						FileName = "/bin/bash",
						Arguments = "/home/niclas/Documents/Streamer/Streamer/channels/swifty.bat",};
					proc = new Process { StartInfo = startInfo, };
					proc.Start ();
					nav = Convert.ToInt32 (Console.ReadLine ());
					break;


				case 9:
					Console.WriteLine ("ending program....:(");	
					willcontinue = false;
					break;

				default:


					nav = 0;
					break;
				}

			}

		} 


	}
}


