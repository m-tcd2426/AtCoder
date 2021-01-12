using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_CS.source
{
    class Question_A
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var spl = line.Trim().Split(' ');

            char[] a = spl[0].ToArray();
            char[] b = spl[1].ToArray();

            int ans = Math.Max(s(a),s(b));
            Console.WriteLine(ans);
        }

        private static int s(char[] n)
        {
            return ((int)n[0] - 48) + ((int)n[1] - 48) + ((int)n[2] - 48);
        }
    }
}
