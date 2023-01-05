namespace SnakeAndLadderProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder geame with players");
            //UseCase1
            WithOnePlayer uC_1WithOnePlayer = new WithOnePlayer();
            uC_1WithOnePlayer.Position();
        }
    }
}