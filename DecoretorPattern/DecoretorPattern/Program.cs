﻿using DecoretorPattern.Interface;
using System;

namespace DecoretorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza queijoDecorator = new QueijoDecorator(pizza);
            IPizza baconDecorator = new BaconDecorator(queijoDecorator);
            IPizza cebolaDecorator = new CebolaDecorator(baconDecorator);


            Console.WriteLine(cebolaDecorator.BuscarTipoPizza());
            Console.WriteLine();
        }
    }
}
