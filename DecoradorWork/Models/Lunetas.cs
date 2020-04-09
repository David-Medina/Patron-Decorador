using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class Lunetas : IngredienteDecorador
    {
        public Lunetas(IHelado helado) : base(helado)
        {
            _nombre = "Lunetas";
            _precio = 0.70;
        }
    }
}
