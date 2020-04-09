using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class Vainilla : IngredienteDecorador
    {
        public Vainilla(IHelado helado) : base(helado)
        {
            _nombre = "Vainilla";
            _precio = 7.0;
        }
    }
}
