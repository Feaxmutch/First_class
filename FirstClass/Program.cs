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
        private string _name;
        private int _health;

        public Player(string name, int health)
        {
            _name = name;
            _health = health;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Здоровье: {_health}");
        }
    }
}
