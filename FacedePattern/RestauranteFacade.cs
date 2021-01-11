using FacedePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacedePattern
{
    // essa classe interage com as classes fornecedorPizza e fornecedorPao
   public class RestauranteFacade
    {
        private IPizza _FornecedorPizza;
        private IPao _FornecedorPao;

        public RestauranteFacade()
        {
            // consulta
            _FornecedorPizza = new FornecedorPizza();
            _FornecedorPao = new FornecedorPao();
        }
        
        //metodos
        public void BuscarPizzaNormal()
        {
            _FornecedorPizza.BuscarPizzaNormal();
        }

        public void BuscarPizzaVegana()
        {
            _FornecedorPizza.BuscarPizzaVegana();
        }

        public void BuscarPaoAlho()
        {
            _FornecedorPao.BuscarPaoAlho();
        }

        public void BuscarPaoAlhoComQueijo()
        {
            _FornecedorPao.BuscarPaoAlhoComQueijo();
        }
    }
}
