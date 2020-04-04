using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer_012
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool validacion = true;

            if (c != 'S')
            {
                validacion = false;
            }

            return validacion;
        }
    }
}
