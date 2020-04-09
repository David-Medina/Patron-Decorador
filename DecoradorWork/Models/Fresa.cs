using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class Fresa : IngredienteDecorador
    {
        public Fresa(IHelado helado) : base(helado)
        {
            _nombre = "Fresa";
            _precio = 5.0;
        }
    }
}
