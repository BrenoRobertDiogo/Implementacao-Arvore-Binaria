using System;
using Operations;
using Enums;
namespace Estruturas {
    
  public class Arvore 
  {
    
    public No Pai { get; set; }
  
    public Arvore(No pai)
    {
      this.Pai = pai;
    }
  
    public Arvore() {  }

    public No BuscaNo (Dado dado, No noAtual)
    {
      if( ArvoreVazia() ) 
      {
        throw new ArgumentException("Arvore está vazia.");
      }

      if(noAtual.Equals(dado))
      {
        return noAtual;
      }

      Lado lado = Operador.LadoEscolher(dado, noAtual);
      
      if( lado.Equals(Lado.Esquerdo) )
      {
        return BuscaNo(dado, noAtual.Esquerdo);
      } 
      if( lado.Equals(Lado.Direito) )
      {
        return BuscaNo(dado, noAtual.Direito);
      }
      return null;
      
    }

     public void InserirNo (No noInserir, No noAtual) {
      
       if( ArvoreVazia() ) 
        {
          this.Pai = noInserir;
           return ;
        }
       Dado dado = noInserir.Dado;    

      if(noAtual.Equals(dado))
      {
        noAtual.Esquerdo = noInserir;
        return ;
      }

       
      Lado lado = Operador.LadoEscolher(dado, noAtual);
       bool inserir = false;
      if((noAtual.Esquerdo is null && lado == Lado.Esquerdo) || (noAtual.Direito is null && lado == Lado.Direito))
      {
        inserir = true;
      }
     switch(lado)
     {
       case Lado.Direito: 
         if(inserir) 
         {
           noAtual.Direito = new No(dado);
           break;
         }
         InserirNo(noInserir, noAtual.Direito);
         break;
       case Lado.Esquerdo: 
         if(inserir) 
         {
           noAtual.Esquerdo = new No(dado);
           break;
         }
         InserirNo(noInserir, noAtual.Esquerdo);
         break; 
       default: break;
     }
       
      return ;
     }

    public void PercorreArvore(No noAtual) 
    {
      if( ArvoreVazia() ) 
      {
        throw new ArgumentException("Arvore está vazia.");
      }
      Console.WriteLine(noAtual);
      
      if(!(noAtual.Esquerdo is null)) 
      {
        PercorreArvore(noAtual.Esquerdo);
      }
      if(!(noAtual.Direito is null)) 
      {
        PercorreArvore(noAtual.Direito);
      }
      
    }
  
    public bool ArvoreVazia() 
    {
      return this.Pai is null;
    }

    public override string ToString()
    {
      return this.Pai.ToString();
    }
    
  }

}