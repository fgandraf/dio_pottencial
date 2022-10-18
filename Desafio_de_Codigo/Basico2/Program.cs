using System;
using System.IO;
using System.Linq;

class DIO
{
    static void Main(string[] args)
    {
        
        int qt = int.Parse(Console.ReadLine());   

        for (int i=1; i <= qt; i++)
        {
            string valor = Console.ReadLine();
            string[] v = valor.Split(" ", 2);
            
            string a = v[0];
            string b = v[1];

            if ( a.EndsWith(b) )
                Console.WriteLine($"encaixa");
              else
                Console.WriteLine($"nao encaixa");
        }
    }
}