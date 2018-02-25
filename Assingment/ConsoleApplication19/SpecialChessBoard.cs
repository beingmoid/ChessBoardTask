﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class SpecialChessBoard:ChessBoard
    {
        public SpecialChessBoard(int height, int width):base(height,width)
        {
            Console.WriteLine("----Chess Board----");
            Console.WriteLine("Enter Two Input as the Size of the board as Width and Height Respectively\n");
            Console.Write("Height:");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Width:");
            width = int.Parse(Console.ReadLine());
            this.width = width;
            this.height = height;
        }
        public void StartChess(Player p1, Player p2, Player p3)
        {
            Console.WriteLine("Information:\n Player 1 Name = {0} \n Player 1 Gender = {1}\n Player 2 Name = {2} \n Player 2 Gender = {3}\n Player 3 Name = {4} \n Player 3 Gender = {5}\n", p1.name, p1.Gender, p2.name, p2.Gender, p3.name, p3.Gender);
        }
        public void StopChess(Player p1, Player p2, Player p3)
        {
            string t = DateTime.Now.ToShortTimeString();
            string time = t.Substring(2, 3);
            int actualTime = int.Parse(time);
            if (actualTime % 5 == 0)
            {
                Console.WriteLine("Player 1 Wins");
            }
            else if (actualTime % 3 == 0)
            {
                Console.WriteLine("Player2 Wins");
            }
            else
            {
                Console.WriteLine("Player 3 Wins");
            }


        }

    }
}
