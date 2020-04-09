using System;
using System.Collections.Generic;
using System.Text;

namespace DecoradorWork.Models
{
    public class Canasta : IHelado
    {
        public double GetCosto()
        {
            return 1.0;
        }

        public string GetDescripcion()
        {
            return "Canasta";
        }
    }
}
