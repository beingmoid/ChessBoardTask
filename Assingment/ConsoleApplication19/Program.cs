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
            
            SpecialChessBoard scb = new SpecialChessBoard();
            
            scb.ShowBoard();
            Console.WriteLine("How Many Players You want to play");
            int pcount = int.Parse(Console.ReadLine());
            if (pcount>1)
            {
                if (pcount==2)
                {
                    Player p1 = new Player();
                    Player p2 = new Player();
                    scb.Inputname(p1, p2);//  overloading
                    scb.StartChess(p1, p2); // inherited overloading
                    scb.StopChess(p1, p2); // inherited overloading
                    
                }
                else 
                {
                    Player p1 = new Player();
                    Player p2 = new Player();
                    Player p3 = new Player();
                    scb.Inputname(p1, p2, p3);//  overloading

                    scb.StartChess(p1, p2, p3);// inherited overloading
                    scb.StopChess(p1, p2, p3);// inherited overloading
                }
                
            }
            else
            {
                Console.WriteLine("Cannot Play");
            }
            

        }
    }
}
