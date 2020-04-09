using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class ChocolateLiquido : IngredienteDecorador
    {
        public ChocolateLiquido(IHelado helado) : base(helado)
        {
            _nombre = "Chocalate Liquido";
            _precio = 0.0;
        }
    }
}
