using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class Vaso : IHelado
    {
        public double GetCosto()
        {
            return 0.0;
        }

        public string GetDescripcion()
        {
            return $"Vaso";
        }
    }
}
