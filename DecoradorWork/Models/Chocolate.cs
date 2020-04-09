using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class Chocolate : IngredienteDecorador
    {
        public Chocolate(IHelado helado) : base(helado)
        {
            _nombre = "Chocolate";
            _precio = 8.0;
        }
    }
}
