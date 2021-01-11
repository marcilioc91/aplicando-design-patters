using FacedePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacedePattern
{
    public class FornecedorPizza : IPizza
    {
        void IPizza.BuscarPizzaNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Buscando Pizza normal...");
        }

        void IPizza.BuscarPizzaVegana()
        {
            Console.WriteLine("Buscando Pizza Vegana...");
            
        }

        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo todas as coberturas de Pizza não vegetais");
        }

     
    }
}
