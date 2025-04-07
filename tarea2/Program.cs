using System;


public class Factorial
{

    public static void Main()
    { 
      int numeros=5;
      
      int resultados= descomponer(numeros);
       Console.WriteLine("el resultado es" + resultados);
     
     
    }
   
     public static int descomponer(int numeros)
      {
          if(numeros <= 1)
          {
            return 1;   

          }

       else
       {
       return numeros * descomponer(numeros - 1);
       }
      
      }

    
    
    
}