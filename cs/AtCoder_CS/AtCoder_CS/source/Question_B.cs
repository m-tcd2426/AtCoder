using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_CS.source
{
    class Question_B
    {
        public static void Main(string[] args)
        {
            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 整数配列
            List<int> x = new List<int>();
            List<int> y = new List<int>();
            for(int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                x.Add(int.Parse(line[0]));
                y.Add(int.Parse(line[1]));
            }

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if (Math.Abs(x[i] - x[j]) >= Math.Abs(y[i] - y[j])) ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
