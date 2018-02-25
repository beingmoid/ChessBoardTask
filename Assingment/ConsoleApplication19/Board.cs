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

        protected internal Board(int height, int width)
        {


         

        }
        public Board()
        {

        }



        public void ShowBoard()
        {
            Console.WriteLine("Size of Your Chessboard is\n Height :{0}\n Width:{1}\n", height, width);

        }
    }
}
