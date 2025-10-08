using System;
using LogFileWriter;

class Program
{
    static void Main(string[] args)
    {
        var fileLogger = new LogFileWriter.LogFileWriter(logFilePath: @"C:\ROOT\BackupFolder\ThisIsATextFile.txt");
        fileLogger.WriteLog(typeOfLevel: TypeOfLevel.INFO,message: "Application has started.");
        fileLogger.WriteLog(typeOfLevel: TypeOfLevel.WARNING,message: "Updates might contain malware!");
        fileLogger.WriteLog(typeOfLevel: TypeOfLevel.ERROR, message: "Error: Updates can't be implemented!");

        Console.ReadLine();
    }
}

