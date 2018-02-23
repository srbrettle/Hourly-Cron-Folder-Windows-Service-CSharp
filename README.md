# Hourly-Cron-Folder-CSharp
Windows Service to run all executables in "C:/Cron" folder every hour. Implemented in C#.
_______________
## Install Service

1. Run command prompt (CMD) with administrator rights.
2. Run the following command (modify values in [ ]): c:\windows\microsoft.net\framework\v[Your installed .NET Framework version]\installutil.exe [The full path to the windows service exe]
3. Restart terminal.
_______________
## Usage
Executables inside "C:/Cron" folder will launch on service startup and then hourly thereafter.
_______________
