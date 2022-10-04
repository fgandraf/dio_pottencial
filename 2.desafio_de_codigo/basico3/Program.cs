using System;
 
class Solution {
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
 
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
            if (count > n)
            {
                Console.WriteLine(false);
            }
        }
         Console.WriteLine(count == 3);
    }
}

//Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos.
//Caso contrário, retorne false. O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m. 

/*
using System;
 
class Solution {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
 
        for (int i = 1; i <= n; i++) {
// TODO: Crie as outras condições necessárias para a resolução do desafio:
            if (n % i ==   ) {
                count++;
            }
            if (count >   ) {
                Console.WriteLine(false);
            }
        }
         Console.WriteLine(count == 3);
    }
}
*/