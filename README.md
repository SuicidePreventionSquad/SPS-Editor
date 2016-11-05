# SPS-Editor
Program to edit the JSON data used in the senior project.

<b>Installation</b>
- Windows
  1. Install .NET Framework version 4.0 (or later)
  2. Run SPS-Editor.exe
- Mac OS X
  1. Download Mono from <a href=http://www.mono-project.com/download/#download-mac>here</a>.
  2. Use the Mono Runtime app to open and run SPS-Editor.exe 
     <b>OR</b> open a terminal and type <code>mono SPS-Editor.exe</code> 
     - The terminal is located in <code>Applications->Utilities->Terminal.app</code>
- Linux
  1. Download Mono from your distribution's repository or from <a href=http://www.mono-project.com/download/#download-lin>here</a>.
  2. Run <code>mono SPS-Editor.exe</code> or open the program with <code>Mono Runtime</code>.

<b>Usage</b>
- You need to be able to upload and download the "data.json" file in the "sps" folder
  from the server where the file is located. It might be necessary to consult ITS 
  to understand how to do this.
1. Download a copy of "data.json" onto your computer.
2. Go to File->Open and select the "data.json" file.
3. Add, delete or modify the information you wish to change.
4. When finished click the close button. You will be asked if you want to
   save the changes you made. Select "Yes" or "No"
5. Replace the "data.json" file on the server with the one that you have 
   modified. (You may need to ask ITS how to do this).

<b>Bugs</b>
- This program has been tested on Windows and Linux. Under Windows, the program
  may contain minor errors that were not detected during testing. Under Linux,
  rendering issues sometimes occur. Unfortunately, these errors are related to
  incompatibilities between Mono and .NET.

<b>License</b>
This software is distributed under the terms of the GPLv3, with the exception of 
3rd party assemblies which are licensed under the terms of their owner. 
