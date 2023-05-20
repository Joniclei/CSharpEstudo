using System;

namespace avaliacao
{
  public class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("JONICLEI BERNARDO JUNIOR - 6pendente % 10 pendente while 20 25 29");
      int op;

      do
      {
        Console.WriteLine("\n \t Escolha uma opção a seguir: \n");
        Console.WriteLine("\n [1] Exercício 1");
        Console.WriteLine("\n [2] Exercício 2");
        Console.WriteLine("\n [3] Exercício 3");
        Console.WriteLine("\n [4] Exercício 4");
        Console.WriteLine("\n [5] Exercício 5");
        Console.WriteLine("\n [6] Use a sua criatividade");
        Console.WriteLine("\n [7] Encerrar \n");
        op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
          case 1:
            {

              Exercicio01.Ex1();

              Console.WriteLine("Digite qualquer tecla para continuar:");
              Console.ReadKey();
              Console.Clear();

              break;
            };

          case 2:
            {

              Exercicio02.Ex02();


              Console.WriteLine("Digite qualquer tecla para continuar:");
              Console.ReadKey();
              Console.Clear();

              break;
            };

          case 3:
            {

              Exercicio03.Ex03();


              Console.WriteLine("Digite qualquer tecla para continuar:");
              Console.ReadKey();
              Console.Clear();

              break;

            };
          case 4:
            {

              Exercicio04.Ex04();

              Console.WriteLine("Digite qualquer tecla para continuar:");
              Console.ReadKey();
              Console.Clear();

              break;
            };

          case 5:
            {
              Exercicio05.Ex05();

              Console.WriteLine("Digite qualquer tecla para continuar:");
              Console.ReadKey();
              Console.Clear();


              break;
            };
          case 6:
            {

              Exercicio06.Ex06();

              Console.WriteLine("Digite qualquer tecla para continuar:");
              Console.ReadKey();
              Console.Clear();

              break;
            };
          case 7:
            {
              Console.WriteLine("Finalizando");
              break;
            };
          default:
            {
              Console.WriteLine("\nOpção inválida");
              break;
            }

        }

      }
      while (op != 7);
      Console.WriteLine("\n\n\n\n\n - Até mais \n\n\n\n\n");
    }
  }
}
