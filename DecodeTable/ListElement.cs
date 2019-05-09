using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeTable
{
    public class ListElement
    {
        public ListElement(int AlphabetPlace,char Letter)
        {
            alphabetplace = AlphabetPlace;
            letter = Letter;
        }

         int alphabetplace;
         char letter;


        public int Alphabetplace { get { return alphabetplace; } }
        public char Letter { get { return letter; } }
    }
}
