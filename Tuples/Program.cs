using System;

namespace Tuples
{
    class Program
    {
        static (string FirstName,string LastName,int Year) GetAnonymous()
        {
            return ("Mary","Shelley", 1797 );
        }
            
        static void Main()
        {
            var anon = GetAnonymous();

            Console.WriteLine(anon.FirstName);
        }
    }
}
