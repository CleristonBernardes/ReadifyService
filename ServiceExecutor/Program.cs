using ServiceExecutor.RedifyReferenceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceExecutor
{
    /// <summary>
    /// Local WebService Executor
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RedPillClient red = new RedPillClient();
                Console.WriteLine(red.FibonacciNumber(10));
                Console.Read();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }

        }
        

    }
}
