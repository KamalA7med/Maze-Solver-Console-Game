using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Solve_Maze
{
   
    internal class Maze
    {
        private int _Length;
        private int _Width;
        public Object[,] Grid;
        private char Block_Symbol;
        private (int x, int y) Exit;
        public Maze(int Length, int Width,char block_Symbol, del Obstacles)
        {
            _Length = Length;
            _Width = Width;
            Exit.x = _Length - 2;
            Exit.y = _Width - 1;
            Grid = new Object[_Length, _Width];
            Block_Symbol = block_Symbol;
            Fill_Maze(Obstacles);
        }
        public bool Check_Movemt(int x, int y)
        {
            if (x >= _Length || y >= _Width || x < 0 || y < 0 || Grid[x, y].IsSolid)
            {
                return false;
            }
            return true;
        }
        private void Fill_Maze(del Obstacles)
        {
            
            for (int x = 0; x < _Length; x++)
            {
                for (int y = 0; y < _Width; y++)
                {
                    if(y==0||y==_Width-1||x==0|| x == _Length - 1|| Obstacles(x, y))
                    {
                        Grid[x, y] = new Object(Block_Symbol, true);
                    }
                    else
                    {
                        Grid[x, y] = new Object(' ', false);
                    }

                }
            }
           //Create Exit
            Grid[Exit.x, Exit.y] = new Object('E', false);
            Grid[Exit.x, Exit.y-1] = new Object(' ', false);
        }
        public  bool IsPlayeratExist(int x,int y)
        {
            return y ==Exit.y&&x == Exit.x;
        }
        public void Draw_Maze(Player player)
        {
           Console.Clear();
            Grid[player.x, player.y] = new Object(player.Symbol, true);
            for (int x = 0; x < _Length; x++)
            {
                for (int y = 0; y < _Width; y++)
                {
                    Console.Write(Grid[x,y].Symbol);
                }
                Console.WriteLine();
            }
        }
       
    }
 
}
