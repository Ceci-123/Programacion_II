using System;

namespace AtrapameSiPuedes
{
    public static class Calculador
    {
        public static float Calcular(int num1, int num2)
        {
            float retorno;
            try
            {
                retorno = (float)num1 / (float)num2;
            }
            
            catch (DivideByZeroException)
            {

                retorno = 99;
            }
            return retorno;
        }
    }
}
