using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeTable
{
    class StringToAnalyse
    {
        public StringToAnalyse(string analyse)
        {
            tab = analyse.ToArray();
        }

        char[] tab;

        public char[] Tab
        {
            get { return tab; }
        }
    }
}
