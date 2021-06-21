using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--Suma de digitos--");

            funciones digitos = new funciones();

            Console.WriteLine(digitos.difitSum(12345));

            Console.WriteLine("");



            Console.WriteLine("--Palíndromos--");

            funciones palindromo = new funciones();

            Console.WriteLine(palindromo.ispalindrome("salas2"));

            Console.WriteLine("");


            Console.WriteLine("--Producto de elementos adyacentes--");

            funciones adyacentes = new funciones();

            Console.WriteLine(adyacentes.maxAdjacentProd(new int[] { 3,6,-2,-5,7,3 }));



        }
    }
}
