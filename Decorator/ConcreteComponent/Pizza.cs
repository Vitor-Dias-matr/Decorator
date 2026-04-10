using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class Pizza: IPizza
    {
        public string Opcionais()
        {
            var pizza = "Pizza padrão ou normal";
            return pizza;
        }

        public decimal Preco()
        {
            var preco = 10.00M;
            return preco;
        }
    }
}
