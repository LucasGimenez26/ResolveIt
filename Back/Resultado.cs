using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Back
{
    public class Resultado
    {
        public double Res { get; set; }

        public void Agregar (string aRes)
        {
            Res = Convert.ToDouble(aRes);
        }
    }
}
