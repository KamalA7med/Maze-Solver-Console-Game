using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Maze
{
    public class Object
    {
        private char _Symbol;
        private bool _Sloid;
        public Object(char symbol, bool sloid)
        {
            _Symbol = symbol;
            _Sloid = sloid;
        }
        public char Symbol { get { return _Symbol; } }

        public bool IsSolid { get { return _Sloid; } }

    }
}
