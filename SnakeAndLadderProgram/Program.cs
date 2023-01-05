namespace SnakeAndLadderProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Snake and Ladder gamee with players");
            //////UC_1
            ////WithOnePlayer uC_1WithOnePlayer = new WithOnePlayer();
            ////uC_1WithOnePlayer.Position();
            ////Console.WriteLine("---------------------------------------");
            //UC_2
            DiceRolls uC_2diceRolls = new DiceRolls();
            uC_2diceRolls.RollDice();
            Console.WriteLine("---------------------------------------");
        }
    }
}