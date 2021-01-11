using FacedePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacedePattern
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoAlho()
        {
            Console.WriteLine("Buscando Pão de Alho...");
        }

        public void BuscarPaoAlhoComQueijo()
        {
            ObterPaoAlhoComQueio();
            Console.WriteLine("Buscando Pão de Alho com queijo...");

        }
        private void ObterPaoAlhoComQueio()
        {
            Console.WriteLine("Buscando queijo...");
        }
    }
}
