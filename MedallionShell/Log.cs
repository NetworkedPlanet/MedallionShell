﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallion.Shell
{
    // TODO conditional attribute
    internal static class Log
    {
        public static void WriteLine(string format, params object[] args)
        {
            var text = string.Format(format, args);

            using (var fs = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            using (var writer = new StreamWriter(fs))
            {
                writer.WriteLine(text);
            }
        }
    }
}