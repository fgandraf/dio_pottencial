using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

public class Program
{
    public static void Main(String[] args)
    {
        int numeroDeEntradas = int.Parse(Console.ReadLine());
        int[] entradas = new int[numeroDeEntradas];
    
        for (int i = 0; i < numeroDeEntradas; i++)
        {
            entradas[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(entradas));
    }
        

    public static int MajorityElement(int[] entradas)
    {
        Dictionary<int, int> dicionario = new Dictionary<int, int>();

        foreach (int item in entradas)
        {
            if (dicionario.ContainsKey(item))
                dicionario[item]++;
            else
                dicionario.Add(item, 1);
        }

        var lista = dicionario.ToList();
        lista.Sort((numero, contagem) => contagem.Value.CompareTo(numero.Value));
        
        int major = lista[0].Key;

        return major;
    }
}