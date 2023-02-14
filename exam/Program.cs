using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b ;
            int[] randomArray = new int[4];
            Random dicer = new Random(); 
            for (int i = 0; i < 4; i++)
            {
                randomArray[i] = dicer.Next(1, 10); 

                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])    
                    {
                        j = 0; 
                        randomArray[i] = dicer.Next(1, 10);
                    }
                }
            }


            do
            {
                Console.WriteLine("輸入4個不同數字: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                int[] guessuser = new int[4];

                guessuser[0] = guess / 1000;
                guessuser[1] = (guess % 1000) / 100;
                guessuser[2] = (guess % 100) / 10;
                guessuser[3] = guess % 10;
                a = 0; b = 0;
                if (guessuser[0] == randomArray[0])
                {
                    a++;
                }
                if (guessuser[1] == randomArray[1])
                {
                    a++;
                }
                if (guessuser[2] == randomArray[2])
                {
                    a++;
                }
                if (guessuser[3] == randomArray[3])
                {
                    a++;
                }
                if (guessuser[0] == randomArray[1] || guessuser[0] == randomArray[2] || guessuser[0] == randomArray[3])
                {
                    b++;
                }
                if (guessuser[1] == randomArray[0] || guessuser[1] == randomArray[2] || guessuser[1] == randomArray[3])
                {
                    b++;
                }
                if (guessuser[2] == randomArray[0] || guessuser[2] == randomArray[1] || guessuser[2] == randomArray[3])
                {
                    b++;
                }
                if (guessuser[3] == randomArray[0] || guessuser[3] == randomArray[1] || guessuser[3] == randomArray[2])
                {
                    b++;
                }
                Console.WriteLine($"你拿到{a}A{b}B");
            }
            while (a < 4);
            {
                Console.WriteLine("恭喜你！猜對了！！");
                Console.WriteLine("遊戲結束，下次再來玩喔～");
            }
            
            




            Console.ReadLine();
        }
    }
}
