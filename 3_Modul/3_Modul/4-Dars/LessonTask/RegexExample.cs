using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._4_Dars.LessonTask
{
    internal class RegexExample
    {
        public int UniqueMorseRepresentations(string[] words) { 
        Dictionary<char, string> dic = new Dictionary<char, string>()
        {
            ['a'] = ".-",
            ['b'] = "-...",
            ['c'] = "-.-.",
            ['d'] = "-..",
            ['e'] = ".",
            ['f'] = "..-.",
            ['g'] = "--.",
            ['h'] = "....",
            ['i'] = "..",
            ['j'] = ".---",
            ['k'] = "-.-",
            ['l'] = ".-..",
            ['m'] = "--",
            ['n'] = "-.",
            ['o'] = "---",
            ['p'] = ".--.",
            ['q'] = "--.-",
            ['r'] = ".-.",
            ['s'] = "...",
            ['t'] = "-",
            ['u'] = "..-",
            ['v'] = "...-",
            ['w'] = ".--",
            ['x'] = "-..-",
            ['y'] = "-.--",
            ['z'] = "--.."
        };
        HashSet<string> morses = new();
            foreach (string word in words)
            {
                string str = "";
                for (int i = 0; i<word.Length; i++)
                    str += dic[word[i]];
                morses.Add(str);
            }
            return morses.Count;
    }
}
}

