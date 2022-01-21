using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracSuperMarioStar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               第幾層                           每層星數
                 1              *                  1
                 2             ***                 3
                 3            *****                5
                 4           *******               7
                 5   ***********************      23
                 6    ****** ******* ******     21 - 2    第7及第15為眼睛
                 7     ***** ******* *****      19 - 2    第6及第14為眼睛
                 8      *****************         17
                 9       ******* *******         7 + 7    中間空1格
                10      *****       *****        5 + 5    中間空7格
                11     ***             ***       3 + 3    中間空13格
                12    *                   *      1 + 1    中間空19格
            */

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 1; i <= 12; i++)
            {
                // 第一段 1-4層;
                if(i <= 4)
                {
                    // 印出空白字元 
                    for (int j = 1; j <= (12 - i); j++)
                    {
                        Console.Write(' ');
                    }

                    // 接在空白字元後照層數規則印星星
                    for (int k = 1; k <= i * 2 - 1; k++)
                    {
                        Console.Write('*');
                    }
                }
                
                // 第二段 5-8層
                if(i >= 5 && i <= 8)
                {
                    // 印出空白字元 
                    for (int j = 1; j <= (i - 5); j++)
                    {
                        Console.Write(' ');
                    }

                    for (int k = 1; k <= 33 - (i * 2); k++)
                    {
                        // 第6-7行碰到眼睛的部分就空白字元
                        if ( 
                                (i == 6 || i == 7) &&
                                ((i + k) == 13 || (i + k) == 21)
                            )
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write('*');
                        }
                    }
                }

                // 第三段9-12層
                if (i >=9 && i <= 12)
                {
                    // 印出空白字元
                    for (int j = 1; j <= 13 - i; j++)
                    {
                        Console.Write(' ');
                    }

                    for (int k = 1; k <= 25 - (i * 2); k++)
                    {
                        Console.Write('*');
                    }

                    // 印出中間空白字元
                    for (int j = 1; j <= (i * 6) - 53; j++)
                    {
                        Console.Write(' ');
                    }

                    for (int k = 1; k <= 25 - (i * 2); k++)
                    {
                        Console.Write('*');
                    }
                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
