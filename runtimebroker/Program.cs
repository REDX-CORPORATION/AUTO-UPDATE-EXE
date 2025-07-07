using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    private const int SW_HIDE = 0;

    static void Main()
    {
        EnsureAdminPrivileges();

        Console.Title = "RED-X UPDATER";
        TypeWrite("[+] RED-X Loader Initializing...", ConsoleColor.Red);
        Thread.Sleep(1000);

        TypeWrite("[+] Checking for updates...", ConsoleColor.Magenta);
        Thread.Sleep(1000);

        string exeUrl = "https://raw.githubusercontent.com/REDX-CORPORATION/ELITEPANELBYRED-X/refs/heads/main/AutoUpdate/demo.exe"; // <-- REPLACE THIS
        string localPath = Path.Combine(Path.GetTempPath(), "UpdatedApp.exe");

        try
        {
            DownloadFile(exeUrl, localPath);
            TypeWrite("[+] Update downloaded successfully!", ConsoleColor.Green);

            TypeWrite("[+] Launching application...", ConsoleColor.Cyan);
            Thread.Sleep(500);

            Process.Start(localPath);
            Environment.Exit(0);
        }
        catch (Exception ex)
        {
            TypeWrite($"[!] Error downloading update: {ex.Message}", ConsoleColor.Red);
            Thread.Sleep(3000);
            Environment.Exit(1);
        }
    }

    static void DownloadFile(string url, string outputPath)
    {
        using (WebClient client = new WebClient())
        {
            client.DownloadFile(url, outputPath);
        }
    }

    static void TypeWrite(string message, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
        Console.WriteLine();
        Console.ResetColor();
    }

    static void EnsureAdminPrivileges()
    {
        if (!IsAdministrator())
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Process.GetCurrentProcess().MainModule.FileName,
                Verb = "runas",
                UseShellExecute = true
            };

            try
            {
                Process.Start(psi);
                Environment.Exit(0);
            }
            catch
            {
                TypeWrite("[❌] Failed to restart with admin rights!", ConsoleColor.Red);
                Environment.Exit(1);
            }
        }
    }

    static bool IsAdministrator()
    {
        using (var identity = System.Security.Principal.WindowsIdentity.GetCurrent())
        {
            var principal = new System.Security.Principal.WindowsPrincipal(identity);
            return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }
    }
}
