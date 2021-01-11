using System;
using System.Collections.Generic;
using System.Text;

namespace FacedePattern
{
    class Pedidos
    {
        static void Main(string[] args)
        {
            var facade = new RestauranteFacade();
            Console.WriteLine("-------------------------PEDIDOS DE PIZZA DO CLIENTE-------------------------");
            facade.BuscarPizzaNormal();
            facade.BuscarPizzaVegana();

            
            Console.WriteLine("-------------------------PEDIDOS DE PIZZA DO CLIENTE-------------------------");
            facade.BuscarPaoAlho();
            facade.BuscarPaoAlhoComQueijo();



        }
    }
}
