using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class ChocoChips : IngredienteDecorador
    {
        public ChocoChips(IHelado helado) : base(helado)
        {
            _nombre = "ChocoChips";
            _precio = 8.0;
        }
    }
}
