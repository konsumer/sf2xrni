using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NRenoiseTools;
using NAudio.SoundFont;
using NAudio.Wave;

using SInstrument = NAudio.SoundFont.Instrument;
using XInstrument = NRenoiseTools.RenoiseInstrument;
using SSampleHeader = NAudio.SoundFont.SampleHeader;
using XSample = NRenoiseTools.InstrumentSample;

namespace Commons.Music.Xrni2Sf2
{
	public class Driver
	{
		public static int Main (string [] args)
		{
			if (args.Length == 0) {
				Console.WriteLine ("Usage: xrni2sf2 [xnrifiles...]");
				return 1;
			}

			var files = new List<string> ();
			foreach (var arg in args) {
				files.Add (arg);
			}

			foreach (var file in files) {
				var path = Path.GetFileNameWithoutExtension(file);
				if (!Directory.Exists (path))
					Directory.CreateDirectory (path);
				var instrument = new XInstrument();
            	instrument.Load(file);
			}



			return 0;
		}
	}
}
