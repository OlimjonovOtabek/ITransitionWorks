using System.Security.Cryptography;
using GameTask4ConsoleApp;
using System.Text.RegularExpressions;
using Validator = GameTask4ConsoleApp.Validator;

class Program
{
    public static void Main(string[] args)
    {

        //while (true)
        //{
        var input = Regex.Replace(Console.ReadLine(), @"\s+", " ")
            .Split()
            .ToList();
        
        try
        {
                var resultOfValidating = Validator.StartToValidate(input);

                while (resultOfValidating)
                {
                    var compMove = RandomNumberGenerator.GetInt32(1,input.Count+1);
                    
                    GameLogic game = new GameLogic(input.Count);

                   
                    if (resultOfValidating) Table.ShowGameTable(input);
                    
                    var option = Console.ReadLine().Replace(" ", "");
                    if (option == "?")
                        Table.ShowHelpMenu(input);
                    
                    //Validator.StartToValidate(option,input.Count);

                    if(option == "0")
                        break; 
                    
                    if (int.Parse(option) <= input.Count)
                        game.FindWinner(int.Parse(option));
                }
        }
        catch (Exception e) 
        { 
            Console.WriteLine(e.Message);
        }
    }
}