using ConsoleTables;
using System.Security.Cryptography;

namespace GameTask4ConsoleApp
{
    public static class Table
    {

        public static void ShowGameTable(List<string> argInputs)
        {
            var game = new GameLogic(argInputs.Count);

            argInputs.Remove("");

            for (int i = 0; i < argInputs.Count; ++i)
            {
                Console.WriteLine($"{i + 1}. {argInputs[i]}");
            }
            Console.WriteLine("?. Help\n0. Exit\n ");
        }

        public static void ShowHelpMenu(List<string> args)
        {
            args.Remove(" ");
            var headerItems = args.Prepend("PC \\ User");
            var table = new ConsoleTable(headerItems.ToArray());

            var gameLogic = new GameLogic(args.Count);

            for (int i = 0; i < args.Count; i++)
            {
                var currentRow = new string[args.Count + 1];
                currentRow[0] = args[i];

                for (int j = 0; j < args.Count; j++)
                {
                    currentRow[j + 1] = gameLogic.FindWinner(i, j);
                }

                table.AddRow(currentRow.ToArray());
            }

            table.Write(Format.Alternative);
        }


    }
}
