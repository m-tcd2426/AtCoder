using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_CS.source
{
    class Question_D
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<long> vote = new List<long>();
            long score = 0;
            for(int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                long a = long.Parse(line[0]);
                long b = long.Parse(line[1]);
                score -= a;
                vote.Add(a + a + b);
            }

            vote.Sort();

            int ans = 0;

            for(int i =  n-1; i >= 0; i--)
            {
                score += vote[i];
                ans++;
                if(score > 0)
                {
                    Console.WriteLine(ans);
                    return;
                }
            }

        }
    }
}
