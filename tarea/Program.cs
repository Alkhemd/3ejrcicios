using System;

public class Torre
{
    public static void Main()
    { 
     Console.WriteLine("Ingrese el numero de discos: ");
    int n=int.Parse(Console.ReadLine());
    torre(n, 'A', 'C', 'B');
    Console.WriteLine("El resultado es: " + n);

   
   }

 public static void torre(int n, char origen, char destino, char auxiliar)
 {
     if(n==1)
     {
         Console.WriteLine("Mover disco 1 de torre " + origen + " a torre " + destino);
     }
     else
     {
         torre(n-1, origen, auxiliar, destino);
         Console.WriteLine("Mover disco" + n + " de torre " + origen + " a torre " + destino);
         torre(n-1, auxiliar, destino, origen);
     }
 

 }

}