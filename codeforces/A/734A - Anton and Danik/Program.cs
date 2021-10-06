namespace Main
{
    public class Program
    {
        public static void Main()
        {
            Console.ReadLine();

            int winner = 0;

            foreach (var ch in Console.ReadLine() ?? "")
            {
                if (ch == 'A') winner++;
                else winner--;
            }

            Console.WriteLine(winner > 0 ? "Anton" : winner < 0 ? "Danik" : "Friendship");
        }
    }
}
