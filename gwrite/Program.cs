using System;
using System.Diagnostics;

namespace gwrite
{
    class Program
    {
        static void Main(string[] args)
        {
            var psi = new ProcessStartInfo("cmd", "/c git init") 
            {
                RedirectStandardOutput = true,
                UseShellExecute =  false,
                CreateNoWindow = true,
                WorkingDirectory = @"C:\jake"
            };

            var proc = new Process()
            {
                StartInfo = psi
            };
            proc.Start();

            Console.WriteLine(proc.StandardOutput.ReadToEnd());
            Console.ReadLine();
        }
    }
}
