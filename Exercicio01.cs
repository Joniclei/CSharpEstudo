

using System;

namespace avaliacao
{

  public class Exercicio01
  {

    public static int Ex1(double tempo);
    {

      // exericio 01(06)1
      double tempo;
    int hora;
    int minutos;
    int segundos;



    hora = (int) (tempo / 3600);
      minutos = (int) ((tempo - (hora* 3600)) / 60);
      segundos = (int) (tempo - (hora* 3600) - (minutos* 60));

      Console.WriteLine(" Horas : " + hora + "\n");
      Console.WriteLine(" Minutos : " + minutos + "\n");
      Console.WriteLine(" Segundos : " + segundos);

      Console.WriteLine("\n");

      return (Console.WriteLine(" Horas : " + hora + "\n"),
      Console.WriteLine(" Minutos : " + minutos + "\n"),
      Console.WriteLine(" Segundos : " + segundos))

    }


}

}
