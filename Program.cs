using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 樂透不重複
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> number = new List<int>();

                // LIST中有1到42     
                for (int i = 1; i < 43; i++)
                {
                    number.Add(i);
                }

                
                Random rand = new Random();

                // 迴圈中產出六個
                for (int i = 0; i < 6; i++)
                {
                    int r = rand.Next(1, number.Count);
                    Console.Write(number[r] + " ");

                    // 每產生一個就從LIST中消失
                    number.RemoveAt(r);
                }

                // 暫停畫面
                Console.ReadKey();
            }
    }
}
