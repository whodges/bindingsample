# bindingsample
Native library binding sample with MAUI

This solution compiles 3 C++ libraries (one for Windows (x64), one for Android (ARM64), and one for iOS (also ARM64)) using shared code.  These libraries export simple 
methods that act on a 'MyCounter' class, a basic class that simply contains an int.  There's a corresponding C# .NET 7.0 wrapper assembly for each of these native libraries.
These wrappers have shared p/invoke code that leverages DllImport to access the exported MyCounter methods in a native lib.  These were created following the instructions
laid out here:  https://learn.microsoft.com/en-us/xamarin/cross-platform/cpp/.

A default template MAUI app then uses these C# wrappers to use a C++ counter to keep track of how many times the button has been clicked.

As of Jan 31, 2023, this works for Windows and Android, but I can't get the iOS version to work.  It throws a DllNotFoundException.
