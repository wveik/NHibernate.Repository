using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.Classes {
    public class HelperWriteLog {
        public static string Prefix { get; set; }
        private static string log_file;

        public static void WriteLog(string log_text) {
            if (String.IsNullOrEmpty(log_file)) {
                log_file = Directory.GetCurrentDirectory() + @"\" + Prefix + "_" + DateTime.Now.ToString().Replace(':', '.') + ".txt";
            }

            Console.WriteLine(log_text);

            if (!File.Exists(log_file)) {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(log_file)) {
                    sw.WriteLine(log_text + " - " + DateTime.Now.ToString());
                }
            } else {
                using (StreamWriter sw = File.AppendText(log_file)) {
                    sw.WriteLine(log_text + " - " + DateTime.Now.ToString());
                }
            }
        }
    }
}
