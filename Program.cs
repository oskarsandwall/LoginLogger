using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Choose a log file location
        // Use a path where the user has write permission.
        string logDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "LoginLogger");

        Directory.CreateDirectory(logDirectory);

        string logFilePath = Path.Combine(logDirectory, "login_log.txt");

        // Build the log line
        string userName = Environment.UserName;
        string machineName = Environment.MachineName;
        string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        string logLine = $"{timeStamp} - User '{userName}' logged in on '{machineName}'";

        // Append to the file
        try
        {
            File.AppendAllText(logFilePath, logLine + Environment.NewLine);
        }
        catch (Exception ex)
        {
            // Optional: write to EventLog or a fallback file if needed
            // For simplicity we just swallow or you can:
            File.AppendAllText("C:\\Temp\\login_error.txt", ex.ToString());
        }
    }
}