using System;

namespace Estruturas {
  public class No {
    public Dado Dado { get; set; }
    public No Esquerdo { get; set; } 
    public No Direito { get;set; }
  
  public No(int dado) 
  {
    this.Dado = new Dado(dado);
  }
  public No(Dado dado) 
  {
    this.Dado = dado;
  }

  public override bool Equals(Object obj) 
  {
    return ((Dado)obj).Numero == this.Dado.Numero;
  }
    
  public override string ToString() 
  {
    return $"{this.Dado}[{this.Esquerdo?.Dado.ToString() ?? ""}][{this.Direito?.Dado.ToString() ?? ""}]";
  }
    
  } // Classe
  
} // Namespace