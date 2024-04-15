using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxdle
{
    internal class DadesPartida
    {
        public static String paraulaSecreta{ get; set; }
        public static int intent{ get; set; }

        public static int columna {  get; set; }

        //public static List<char> lletresIntent { get; set; }

        public static int ComprovarLletra(int index, char lletra)
        {
            List<char> paraulaSecretachars = paraulaSecreta.ToCharArray().ToList<char>();
            
            if (paraulaSecreta[index].Equals(lletra))
            {
                return 1;
            }
            if (paraulaSecreta.Contains(lletra))
            {
                return 0;
            }
            return -1;
        }
    }
}
