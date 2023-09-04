using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateDecider
{
    static class CoinFlip
    {
        public static void Flip()
        {
            Random rnd = new Random();
            int result = rnd.Next(0,2);

            if (result == 0)
            {
                Console.Clear();
                Console.WriteLine("                ______________\r\n    __,.,---'''''              '''''---..._\r\n ,-'             .....:::''::.:            '`-.\r\n'           ...................'\r\n            '''''''''''''''''''.               ,\r\n|'-.._           ''''':::..::':          __,,-\r\n '-.._''`---.....______________.....---''__,,-\r\n      ''`---....._____Heads____.....---'");
            }
            if (result == 1)
            {
                Console.Clear();
                Console.WriteLine("                ______________\r\n    __,.,---'''''              '''''---..._\r\n ,-'             .....:::''::.:            '`-.\r\n'           ...:::.....       '\r\n            ''':::'''''       .               ,\r\n|'-.._           ''''':::..::':          __,,-\r\n '-.._''`---.....______________.....---''__,,-\r\n      ''`---....._____Tails____.....---'");
            }
        }
    }
}
