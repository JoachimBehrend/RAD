using System;
namespace ImplementationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tests\n");
            byte[] bytes = {174, 46, 205, 25, 59, 135, 39, 23};
            BigInteger a = new BigInteger(bytes);
            Console.WriteLine(a); 
        }
    }
}
