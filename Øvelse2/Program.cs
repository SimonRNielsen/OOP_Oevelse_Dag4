using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] test = new int[1];
                test[1] = 1;
                int[] test2 = null;
                test2[1] = 1;
            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Jobs done!");
            }
            Console.ReadKey();
        }
    }
}
