using System;
namespace Examen
{
    public class funciones
    {


        public int difitSum(int numero)
        {

            string valor = Convert.ToString(numero);

            int temp;
            int total = 0;

            for (int i = 0; i < valor.Length; i++)
            {
                temp = 0;
                temp = int.Parse(Convert.ToString(valor[i]));
                total = total + temp;

            }

            return total;
        }



        public bool ispalindrome(string cadena)
        {

            bool bandera = false;

        
            char[] temp = cadena.ToCharArray();

            Array.Reverse(temp);

            string reves = new string(temp);


            if (cadena.ToLower().Equals(reves.ToLower()))
            {

                bandera = true;

            }
            else
            {
                bandera = false;

            }

            return bandera;

        }



        public int maxAdjacentProd(int[] arreglo)
        {

            int producto = 0;

            int temp = arreglo[0] * arreglo[1];


            for (int i = 0; i < arreglo.Length - 1; i++)
            {

                producto = arreglo[i] * arreglo[i + 1];

                if (producto > temp)
                {

                    temp = producto;

                }

            }

            return temp;

        }


    }
}
