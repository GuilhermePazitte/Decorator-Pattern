﻿using DecoretorPattern.Interface;

namespace DecoretorPattern
{
    //Concrete Decorator
    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza) 
            : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de queijo";
            return pizza;
        }
    }
}
