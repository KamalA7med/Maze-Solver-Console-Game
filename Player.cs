using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Maze
{
    internal class Player : Object
    {
        public int x;
        public int y;
        
       public Player(int x, int y,char sym,bool issolid):base(sym, issolid)
        {
            this.x = x;
            this.y = y;
        }
        public bool Move(int new_x, int new_y, Maze maze)
        {
            if (maze.Check_Movemt(new_x, new_y))
            {
                maze.Grid[x,y]=new Object(' ',false);
               x= new_x ;
               y= new_y;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
