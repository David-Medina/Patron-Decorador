using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class Platano : IngredienteDecorador
    {
        public Platano(IHelado helado) : base(helado)
        {
            _nombre = "Platano";
            _precio = 5.0;
        }
    }
}
