using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Board
    {
        protected internal int width { get; set; }
        protected internal int height { get; set; }

        public Board() //base class constructor
        {
            Console.WriteLine("----Chess Board----");
            Console.WriteLine("Enter Two Input as the Size of the board as Width and Height Respectively\n");
            Console.Write("Height:");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Width:");
            width = int.Parse(Console.ReadLine());

         

        }
        



        public void ShowBoard()
        {
            Console.WriteLine("Size of Your Chessboard is\n Height :{0}\n Width:{1}\n", height, width);

        }
    }
}
