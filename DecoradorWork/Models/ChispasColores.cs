using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class ChispasColores : IngredienteDecorador
    {
        public ChispasColores(IHelado helado) : base(helado)
        {
            _nombre = "Chispas Colores";
            _precio = 0.20;
        }
    }
}
