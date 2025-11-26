using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Maze
{
    public delegate bool del(int x, int y);
    internal class Game
    {
        public Player _player;
        public Maze _maze;
       
        public (int ,int) getMove(ConsoleKey key)
        {
            switch(key)
            {
                case ConsoleKey.RightArrow:
                    {
                        return ValueTuple.Create(0, 1);
                        break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        return ValueTuple.Create(0, -1);
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        return ValueTuple.Create(1, 0);
                        break;
                    }
                case ConsoleKey.UpArrow:
                    {
                        return ValueTuple.Create(-1, 0);
                        break;
                    }
                default:
                    return ValueTuple.Create(0, 0);


            }

        }
        private del Get_Diffcuilty()
        {
           
            Console.WriteLine("[1] Easy");
            Console.WriteLine("[2] Midum");
            Console.WriteLine("[3] Hard");
            Console.WriteLine("-----------------------");
            Console.Write("Enter Diffculty : ");
           int option=int.Parse( Console.ReadLine());
            switch(option)
            {
                case 1:
                    {
                        return Easy_Level;
                        break;
                    }
                case 2:
                    {
                        return Midum_Level;
                        break;
                    }
                case 3:
                    {
                        return Hard_Level;
                        break;
                    }
                default:
                    {
                        return Midum_Level;
                        break;
                    }

            }
        }
        public (int,int,char,del) GetUserOptions()
        {
            Console.Write("Enter Player Symbol : ");
            char palyer_Symbol = char.Parse(Console.ReadLine());
            _player = new Player(1, 1, palyer_Symbol, true);
            Console.Write("Enter Length Of Maze  : ");
            int Length = int.Parse(Console.ReadLine());
            Console.Write("Enter Width Of Maze  : ");
            int Width = int.Parse(Console.ReadLine());
            Console.Write("Enter Block Symbol : ");
            char Block_Symbol = char.Parse(Console.ReadLine());
           del diff= Get_Diffcuilty();
           return ValueTuple.Create(Length,Width,Block_Symbol,diff);
        }
        private void Print_Winning_Pharse()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("                 You Win");
            Console.WriteLine("----------------------------------------");
        }

        public void Start_Game()
        {
            (int Length, int Width, char block_symbol, del diff)User_Options=GetUserOptions();

            _maze = new Maze(User_Options.Length, User_Options.Width, User_Options.block_symbol, User_Options.diff);

            while (true)
            {
                _maze.Draw_Maze(_player);
                if(_maze.IsPlayeratExist(_player.x,_player.y))
                {
                    Print_Winning_Pharse();
                    return;
                }
       
        ConsoleKeyInfo key=Console.ReadKey();
                (int x, int y) Move = getMove(key.Key);
                _player.Move(_player.x + Move.x, _player.y + Move.y, _maze);    
                
            }
        }
        
        private bool Easy_Level(int x, int y)
        {
            return (x + 2 * y) % 9 == 0;
        }
        private bool Midum_Level(int x, int y)
        {
            return (x * y + x + y) % 7 == 0;
        }
        private bool Hard_Level(int x, int y)
        {
            return ((x * x) ^ (y * y) ^ (x * y) ^ x ^ y) % 7 == 0;
        }

    }
}
