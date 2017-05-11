using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.DSP;

namespace Lab_3
{
    public class SoundFilter
    {
        public string Name { get; set; }
        public Func<ISampleSource, BiQuad> Filter { get; set; }
    }
}
