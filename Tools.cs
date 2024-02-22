using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fortnite
{
    internal class Tools
    {
        // Holds Global Vars
        public static string toolName = "Fortnite Checker";
        public static string author = "HyperionCSharp on GitHub";
        public static string version = "0.1 - Testing";
        public static string discord = "https://github.com/HyperionCSharp/FortniteChecker";

        public static string ComboName { get; set; }
        public static string ProxyName { get; set; }
        public static string ProxyType { get; set; }
        public static int ComboCount { get; set; }
        public static int ProxyCount { get; set; }
        public static ConcurrentQueue<string> Combos { get; set; }
        public static ConcurrentQueue<string> Proxies { get; set; }

        public static List<Thread> ActiveThreads = new List<Thread>();

        public static bool PrintBads { get; set; }
        public static bool PrintFrees { get; set; }
        public static bool PrintErrors { get; set; }
        public static bool SaveBads { get; set; }
        public static bool SaveFrees { get; set; }
        public static bool ErrorLog { get; set; }
        public static bool IsLoggedIn { get; set; }

        public static int Hits = 0;
        public static int Frees = 0;
        public static int Bads = 0;
        public static int Errors = 0;
        public static int Checks = 0;
        public static int Cpm_Builder = 0;
        public static int Cpm_Final = 0;

        public static int Threads = 0;
        public static int RunningThreads { get; set; }
    }
}
