using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class Barquillo : IHelado
    {
        public double GetCosto()
        {
            return 0.5;
        }

        public string GetDescripcion()
        {
            return "Barquillo";
        }
    }
}
