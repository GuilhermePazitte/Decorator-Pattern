using DecoretorPattern.Interface;

namespace DecoretorPattern
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Esta é uma Pizza Normal";
            return pizza;
        }

    }
}
