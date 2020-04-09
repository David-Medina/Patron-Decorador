using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class Fresas : IngredienteDecorador
    {
        public Fresas(IHelado helado) : base(helado)
        {
            _nombre = "Agregado de Fresas";
            _precio = 7.0;
        }
    }
}
