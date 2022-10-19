using System;

class Desafio
{
  public static void Main()
  {
    int quantidadeDeTestes = 3;
      
    while (quantidadeDeTestes > 0)
    {
      var quantidadeDeTartarugasNoGrupo = Int32.Parse(Console.ReadLine());

      if (quantidadeDeTartarugasNoGrupo >= 1 && quantidadeDeTartarugasNoGrupo <= 500)
      {
        string[] velocidades = Console.ReadLine().Split(" ");
        var maiorVelocidade = Int32.Parse(velocidades[0]);

        for (int i = 0; i < velocidades.Length; i++)
        {
          var tartaruga = Int32.Parse(velocidades[i]);
          
          if (tartaruga > maiorVelocidade)
          {
            maiorVelocidade = tartaruga;
          }
        }

        if (maiorVelocidade < 10)
        {
          Console.WriteLine(1);
        }
        else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
        {
          Console.WriteLine(2);
        } 
        else if (maiorVelocidade >= 20)
        {
          Console.WriteLine(3);
        }
        
        quantidadeDeTestes--;
      }
      else
      {
        Console.WriteLine("Insira um número entre 1 e 500");
      }

    }

  }

}