using System;

namespace GuidGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;

            while (keepLooping)
            {
                Console.WriteLine("Welcome to the GUID Generator!");
                Console.Write("Here's a new GUID for your use: ");
                Guid GuidToken = Guid.NewGuid();
                Console.WriteLine(GuidToken);

                Console.WriteLine("Would you like another? (Y/N)");
                var input = Console.ReadLine();
                if (input.ToUpper().Equals("N"))
                    keepLooping = false;
            }

        }
    }
}
