using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class ChessBoard:Board
    {
        
        public ChessBoard(int height, int width):base(height,width)
        {
            
            

        }
        public void Inputname(Player p1, Player p2)
        {
            Console.Write("Player 1 Name:");
            p1.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Player 1 Gender");
            p1.Gender = Console.ReadLine();
            Console.Write("Player 2 Name:");
            p2.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Player 2 Gender");
            p2.Gender = Console.ReadLine();
        }
        public void Inputname(Player p1, Player p2,Player p3)
        {
            Console.Write("Player 1 Name:");
            p1.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Player 1 Gender");
            p1.Gender = Console.ReadLine();
            Console.Write("Player 2 Name:");
            p2.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Player 2 Gender");
            p2.Gender = Console.ReadLine();
            Console.Write("Player 3 Name:");
            p3.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Player 3 Gender");
            p3.Gender = Console.ReadLine();
        }
        public void StartChess(Player p1,Player p2)
        {
            Console.WriteLine("Information:\n Player 1 Name = {0} \n Player 1 Gender = {1}\n Player 2 Name = {2} \n Player 2 Gender = {3}\n",p1.name,p1.Gender,p2.name,p2.Gender);
        }


        public void StopChess(Player p1, Player p2)
        {
            string t = DateTime.Now.ToShortTimeString();
            string time = t.Substring(2, 3);
            int actualTime = int.Parse(time);
            if (actualTime % 5 == 0)
            {
                Console.WriteLine("Player 1 Wins");
            }
            else
            {
                Console.WriteLine("Player2 Wins");
            }


        }
    }
}
