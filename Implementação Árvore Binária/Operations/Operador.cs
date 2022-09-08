using System;
using Estruturas;
using Enums;

namespace Operations
{
    public static class Operador
    {

        public static Lado LadoEscolher(Dado dado, No no)
        {

            // Caso esquerdo
            if (no.Dado.Numero > dado.Numero)
            {
                return Lado.Esquerdo;
            }
            else
            {
                return Lado.Direito;
            }

        }

    } // Classe
} // Namespace