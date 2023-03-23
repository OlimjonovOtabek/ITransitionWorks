using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace GameTask4ConsoleApp
{
    public  class Generator
    {
        public static string GenerateHmacKey(List<string> moves , int computerMove)
        {
            var bytes = BitConverter.GetBytes(computerMove);
            var key = BitConverter.ToString(bytes).Replace("-", "");

            var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(key));
            var hmacKey = hmac.ComputeHash(Encoding.UTF8.GetBytes(moves[computerMove]));
            
            return BitConverter.ToString(hmacKey).Replace("-", "");
        }

         
    }
}
