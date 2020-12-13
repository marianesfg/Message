using System;

using System.Threading.Tasks;

namespace Message
{
    class Program
    {
        public static void Main()
        {
            PrintMessage("eae");

            Console.ReadKey();
        }


        public static async Task<string> Nova()
        {
            return "New message";
        }

        static async void PrintMessage(string name)
        {
            Console.WriteLine("{0}", await Task.Run(() => GetMessage(name)));
                             
            var res1 = await Nova();
            Console.WriteLine(res1);
        }

        static string GetMessage(string name)
        {
            return "Hi, " + name;
        }
    }
}
