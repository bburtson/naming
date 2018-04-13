using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soleran.CodeTherapy.Naming.PalendromChecker
{
    public class PalindromeChecker
    {

        // pal·in·drome ˈpalənˌdrōm
        // noun
        // a word, phrase, or sequence that reads the same backward as forward, e.g., madam or nurses run.

        public bool Test(string strInput)
        {
            string strTrimmed = strInput.Replace(" ", "");
            string strReversed = new string(strTrimmed.Reverse().ToArray());
            return strReversed.Equals(strReversed);
        }

        public bool Check(string input)
        {
            input = input.Replace(" ", "");
            var reversed = new string(input.Reverse().ToArray());
            return reversed.Equals(input);
        }

        public bool IsPalendrome(string input)
        {
            var forwards = input.Replace(" ", "");
            var backwards = new string(forwards.Reverse().ToArray());
            return backwards.Equals(forwards);
        }
    }
}
