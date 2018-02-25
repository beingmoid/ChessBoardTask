using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SpecialChessBoard scb = new SpecialChessBoard(3,4);
            
            scb.ShowBoard();
            Console.WriteLine("How Many Players You want to play");
            int pcount = int.Parse(Console.ReadLine());
            if (pcount>1)
            {
                if (pcount==2)
                {
                    Player p1 = new Player();
                    Player p2 = new Player();
                    scb.Inputname(p1, p2);
                    scb.StartChess(p1, p2);
                    scb.StopChess(p1, p2);
                    
                }
                else 
                {
                    Player p1 = new Player();
                    Player p2 = new Player();
                    Player p3 = new Player();
                    scb.Inputname(p1, p2,p3);
                
                    scb.StartChess(p1, p2,p3);
                    scb.StopChess(p1, p2, p3);
                }
                
            }
            else
            {
                Console.WriteLine("Cannot Play");
            }
            

        }
    }
}
