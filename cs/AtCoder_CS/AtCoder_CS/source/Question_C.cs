using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_CS.source
{
    class Question_C
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            List<string> s = new List<string>();
            for(int i = 0; i < n; i++)
            {
                s.Add(Console.ReadLine());
                if(s[i][0] == '!')
                {
                    s[i] = s[i].Substring(1) + "!";
                }
            }
            s.Sort();
            for (int i = 1; i < n; i++)
            {
                if(s[i] == s[i - 1] + "!")
                {
                    Console.WriteLine(s[i-1]);
                    return;
                }
            }
            Console.WriteLine("satisfiable");
        }
    }
}
