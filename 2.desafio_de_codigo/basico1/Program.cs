using System;

class DIO
{
       
    static void Main(string[] args)
    {
        Console.WriteLine("Digito um número");
        int n = int.Parse(Console.ReadLine());
        int p = 1;
        int s = 0;
        while (n > 0)
        {
            int l = n % 10;
            p *= l;
            s += l;
            n /= 10;
        }
        Console.WriteLine("Resultado: " + (p-s));
    }

}