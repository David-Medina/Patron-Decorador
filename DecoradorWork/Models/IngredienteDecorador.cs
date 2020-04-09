using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public abstract class IngredienteDecorador : IHelado
    {
        private IHelado _helado;
        protected string _nombre = "Null";
        protected double _precio = 0.0;
        
        public IngredienteDecorador(IHelado helado)
        {
            _helado = helado;
        }
        public string GetDescripcion()
        {
            return $"{_helado.GetDescripcion()}, {_nombre}";
        }

        public double GetCosto()
        {
            return _helado.GetCosto() + _precio;
        }
    }
}
