using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class ChocoKrispis : IngredienteDecorador
    {
        public ChocoKrispis(IHelado helado) : base(helado)
        {
            _nombre = "ChocoKrispis";
            _precio = 0.50;
        }
    }
}
