using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeTable
{
   public class Functions
    {
        public Functions()
        {

        }

        string[] solution;
        List<ListElement> alphabet;
        

        public string[] Calculate(List<ListElement> alphabet,char[] letter)
        {
            string[] result = new string[25];
            string newstring = "";
            int actual;
            int future;
            char futureLetter;

            for (int i = 0; i <= 25; i++)
            {
                newstring = "";
                foreach(char let in letter)
                {
                    
                    if (!isASpace(let))
                    {

                        actual = actualPosition(alphabet, let);
                        future = newPosition(actual, i);
                        futureLetter = newLetter(alphabet, future);
                        newstring += Convert.ToString(futureLetter);
                    }
                    else
                        newstring += let.ToString();
                    
                }

                if (i != 0)
                    result[i - 1] = newstring;
                else
                    result[i] = newstring;

            }

            return result;
        }


        private bool isASpace(char letter)
        {
            if (letter == ' ')
                return true;
            else
                return false;
        }

        private int actualPosition(List<ListElement> element, char letter)
        {
            int position;
            position = element.Find(x => x.Letter == letter).Alphabetplace;

            return position;
        }

        private char newLetter(List<ListElement> element, int position)
        {
            char let;
            let = element.Find(x => x.Alphabetplace == position).Letter;


            return let;
        }

        private int newPosition(int position,int addition)
        {
            int result;

            result = position + addition;
            if (result > 25)
                result = result - 26;

            return result;
        }
    }
}
