using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    public static class Int32Extendida
    {
        public static string FizzBuzz(this Int32 variable)
        {
            int flag = 0;
           StringBuilder retorno = new StringBuilder();
            if (variable % 3 == 0)
            {
                retorno.Append("fizz");
                flag = 1;
            }
            if (variable % 5 == 0)
            {
                if(flag == 1)
                {
                    retorno.Append(" ");
                }
                retorno.Append("buzz");
            }
            else if(!(variable % 3 == 0) && !(variable % 5 == 0))
            {
                retorno.Append(variable);
            }
            return retorno.ToString();
        }
    }
}
