using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyEngine
{
 public  static class RandomSpecial
    {
        static Random random = new Random(seed);
        private static int seed;     
        public static int GetRandom(int last)
        {
            seed = 20;
           return random.Next(0,last);
        }  
    }
}
