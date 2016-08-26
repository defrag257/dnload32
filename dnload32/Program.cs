using System;
using System.Collections.Generic;
using System.Text;

namespace dnload32
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                string[] subargs = new string[args.Length - 1];
                Array.Copy(args, 1, subargs, 0, subargs.Length);
                AppDomain.CurrentDomain.ExecuteAssembly(args[0], null, subargs);
            }
            else
            {
                Console.WriteLine("Run a .NET Framework program under {0}-bit environment.", IntPtr.Size * 8);
                Console.WriteLine("Usage: {0} filename.exe [args]", AppDomain.CurrentDomain.FriendlyName);
            }
        }
    }
}
