all: sf2xrni.exe xrni2sf2.exe

sf2xrni.exe : sf2xrni.cs
	mcs -platform:x86 -r:NAudio.dll -r:NRenoiseTools.dll sf2xrni.cs -debug

xrni2sf2.exe : xrni2sf2.cs
	mcs -platform:x86 -r:NAudio.dll -r:NRenoiseTools.dll xrni2sf2.cs -debug

clean:
	rm sf2xrni.exe xrni2sf2.exe

dist:
	rm -f sf2xrni-latest.zip
	zip sf2xrni-latest.zip sf2xrni.exe sf2xrni.cs xrni2sf2.exe xrni2sf2.cs NAudio.dll NRenoiseTools.dll ICSharpCode.SharpZipLib.dll README Makefile
