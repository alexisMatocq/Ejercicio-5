using System;

class MainClass {
  public static void Main (string[] args) {

  string R1, R2, R3;
  int N1, N2, N3;


    Console.WriteLine ("Ingrese las medidas de los lados de un triangulo");

    R1 = Console.ReadLine ();
    R2 = Console.ReadLine ();
    R3 = Console.ReadLine ();

    N1 = int.Parse(R1);
    N2 = int.Parse(R2);
    N3 = int.Parse(R3);


    if ((N1 == N2) && (N2 == N3))
  {Console.WriteLine ("El triangulo es Equilatero");}

  else if (N1 == N2)
  {Console.WriteLine ("El triangulo es Isosceles");}


  else if (N1 == N3)
  {Console.WriteLine ("El triangulo es Isosceles");}


  else if (N2 == N3)
  {Console.WriteLine ("El triangulo es Isosceles");}


  else
  {Console.WriteLine ("El triangulo es Escaleno" );}



  }
}
