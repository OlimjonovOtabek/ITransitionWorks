using System.Security.Cryptography;

namespace GameTask4ConsoleApp
{
    public class GameLogic
    {
        public int MovesCount { get; set; }
        public GameLogic(int inputArgsCount)
        {
            MovesCount = inputArgsCount;
        }
        public void FindWinner(int userMove)
        {
           
            var computerMove = RandomNumberGenerator.GetInt32(1,MovesCount+1);

            Console.WriteLine($"Computer move: {computerMove}");
            
            if (computerMove == userMove)
                Console.WriteLine("It is Draw");
            else if ((userMove > computerMove && userMove - computerMove > userMove / 2) ||
                (userMove < computerMove && computerMove - userMove <= MovesCount / 2))
                Console.WriteLine("You Win");
            else
                Console.WriteLine("You lose");
        }

        public string FindWinner(int userMove, int computerMove)
        {
            if (computerMove == userMove)
                return "Draw";
            else if ((userMove > computerMove && userMove - computerMove > userMove / 2) ||
                     (userMove < computerMove && computerMove - userMove <= MovesCount / 2))
                return "Win";
            else
                return "Lose";
        }
    }
}
