using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public static class TimeSpanExtensions
    {
        public static string ToPrettyFormat(this TimeSpan span)
        {
            if (span == TimeSpan.Zero) return "0";

            return string.Format("{0}:{1}", span.Minutes, span.Seconds.ToString("D2"));
        }
    }
}