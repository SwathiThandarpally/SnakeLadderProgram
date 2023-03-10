namespace SnakeAndLadderProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Snake and Ladder game with players");
            //UC_1
            WithOnePlayer uC_1WithOnePlayer = new WithOnePlayer();
            uC_1WithOnePlayer.Position();
            Console.WriteLine("---------------------------------------");
            //UC_2
            DiceRolls uC_2diceRolls = new DiceRolls();
            uC_2diceRolls.RollDice();
            Console.WriteLine("---------------------------------------");
            //UC_3
            CheckPosition uC_3checkposition = new CheckPosition();
            uC_3checkposition.Moves();
            Console.WriteLine("---------------------------------------");
            //UC_4
            RepeatTill100 uC_4RepeatTill100 = new RepeatTill100();
            uC_4RepeatTill100.Repeat();
            Console.WriteLine("---------------------------------------");
            //UC_5
            PlayerPositionis100 uC_5playerposition = new PlayerPositionis100();
            uC_5playerposition.Winning();
            Console.WriteLine("---------------------------------------");
            //UC_6
            ReportNumTimes uC_6reportnumTimes = new ReportNumTimes();
            uC_6reportnumTimes.Report();
            Console.WriteLine("---------------------------------------");
            //UC_7
            WithTwoPlayers uC_7withTwoPlayers = new WithTwoPlayers();
            uC_7withTwoPlayers.TwoPlayer();
        }
    }
}