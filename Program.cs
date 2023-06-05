using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ClassPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(0, 0);

            renderer.DrowPlayer(player.X, player.Y);
        }
    }

    class Player
    {
        private int _x;
        private int _y;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Renderer
    {
        public void DrowPlayer(int x, int y, char ch = '$')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }
    }
}