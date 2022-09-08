using System;
namespace Estruturas 
{
  public class Dado 
  {
    public int Numero;
  
    public Dado(int numero) 
    {
      this.Numero = numero;
    }

    public override string ToString () 
    {
      return Numero.ToString();
    }
    
  } // Classe
} // Namespace

