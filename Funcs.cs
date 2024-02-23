using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fortnite
{
    internal class Funcs
    {
        public static string ParseToken(string content, string leftString, string rightString)
        {
            var returnThis = content.Split(new string[] { leftString }, StringSplitOptions.None)[1];
            returnThis = returnThis.Split(new string[] { rightString }, StringSplitOptions.None)[0];
            return returnThis;
        }

        /// <summary>
        /// IGNORE THIS I WILL FIX LATER JUST TEMP FOR NOW ;)
        /// </summary>
        public static void CalcCPM()
        {
            for (; ; )
            {
                Tools.Cpm_Builder = 0;
                Thread.Sleep(1000);
                Tools.Cpm_Final = Tools.Cpm_Builder;
                Tools.Cpm_Final *= 60;
            }
        }

        ///
        // IF YOU WANT TO USE DISCORD RPC HERE I MADE THIS. YOU CODE THE REST
        ///
        /*public static void RPCUpdater()
        {
            Thread.Sleep(500);

            for (; ; )
            {
                string Status = Tools.RunningThreads > 0 ? "Running" : "Paused";
                string Details = string.Format("Hits: {0} - Free: {1} - Bads: {2} - CPM: {3} - {4}", new object[]
                {
                    Tools.Hits,
                    Tools.Frees,
                    Tools.Bads,
                    Tools.Cpm_Final,
                    Status,
                });

                string status = $"Checking: {Tool.Toolname}";
                RPC.Handler.UpdatePresence(Details, status);
                Thread.Sleep(5000);
            }
        }*/
    }
}
