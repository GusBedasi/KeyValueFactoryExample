using System;

namespace KeyValueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var afFactory = new AntifraudResponseFactory();
            var response = afFactory.GetAntifraudResponseBasedOnStatus("refused", "acquirer");

            Console.WriteLine(response?.Score);
            Console.WriteLine(response?.ProviderName);
            Console.WriteLine(response?.Status);
        }
    }
}
