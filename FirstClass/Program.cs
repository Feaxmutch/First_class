namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new("BaTpyshKa", 100);
            player.ShowInfo();
            Console.ReadKey();
        }
    }

    public class Player
    {
        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public string Name { get; }

        public int Health { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Здоровье: {Health}");
        }
    }
}
