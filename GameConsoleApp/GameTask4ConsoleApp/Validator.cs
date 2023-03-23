namespace GameTask4ConsoleApp
{
    public class Validator
    {

        public static bool StartToValidate(List<string> argsInput)
        {

            argsInput.Remove("");
            if (argsInput.Distinct().Count() != argsInput.Count)
                throw new Exception("Input should be not repeated");
            if (argsInput.Count() % 2 == 0 | argsInput.Count() < 3)
                throw new Exception(" Input count should be an odd and minimum number of elements should be 3");

            return true;
        }

        public static void StartToValidate(string option, int moveCount)
        {
            if (option.Length > 1)
                throw new Exception("Input Error. Input should be only number or character! Please rewrite 8");
        }
    }
}
