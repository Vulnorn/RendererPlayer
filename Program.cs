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
            Player player = new Player(10, 10);

            player.SetAvatar();
            renderer.ShowPlayer(player);
        }
    }

    class Player
    {
        public Player(int x, int y)
        {
            X = x;
            Y = y;
            Avatar="$";
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public string Avatar { get; private set; }

        public void SetAvatar()
        {
            Console.WriteLine($"Введите символ для аватара игрока.");
            Avatar = Console.ReadLine();

            if (Avatar=="")
            {
                Avatar = "$";
            }
        }
    }

    class Renderer
    {
        public void ShowPlayer(Player player)
        {
            Console.SetCursorPosition(player.X, player.Y);
            Console.Write(player.Avatar);
        }
    }
}