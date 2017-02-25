using System;
using System.Collections.Generic;

namespace Lab_1
{
    static class Configuration
    {
        public static ICollection<String> SupportedFormats
        {
            get
            {
                var supportedFormats = new List<string>();
                supportedFormats.Add("*.jpg");
                supportedFormats.Add("*.jpeg");
                supportedFormats.Add("*.png");
                return supportedFormats;
            }
        }
    }
}
