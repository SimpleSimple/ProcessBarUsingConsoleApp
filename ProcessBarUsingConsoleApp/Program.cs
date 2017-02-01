using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessBarUsingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //设置光标位置，当前位置为第1列第1行
            Console.SetCursorPosition(1, 1);

            for (int i = 0; i <=50; i++)
            {
                for (int y = 0; y < i; y++)
			    {
                    Console.Write(":");
			    }

                Console.Write("{0}/50",i);
                //重置光标设置为第1列第1行
                Console.SetCursorPosition(1, 1);
            }
            Console.ReadLine();
        }
    }
}
