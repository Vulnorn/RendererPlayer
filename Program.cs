namespace ClassPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(10, 10);

            player.SetAvatar();
            renderer.DrawPlayer(player);
        }
    }

    class Player
    {
        public Player(int x, int y)
        {
            XСoordinate = x;
            YCoordinate = y;
            Avatar="$";
        }

        public int XСoordinate { get; private set; }
        public int YCoordinate { get; private set; }
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
        public void DrawPlayer(Player player)
        {
            Console.SetCursorPosition(player.XСoordinate, player.YCoordinate);
            Console.Write(player.Avatar);
        }
    }
}