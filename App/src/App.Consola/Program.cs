using System;
using fracciones;

namespace UsoFraccion
{
    class Program
    {

        private static int panel(string lugar, int numF)
        {
            Console.WriteLine("Introduzca el " + lugar + " de la fraccion" + numF);
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        public static void main(string[] args)
        {

            int numerador1 = panel("NUMERADOR", 1);
            
            int denominador1 = panel("DENOMINADOR", 1);
            
            int numerador2 = panel("NUMERADOR", 2);

            int denominador2 = panel("DENOMINADOR", 2);

            Fraccion fraccion1 = new Fraccion(numerador1 , denominador1);
            Fraccion fraccion2 = new Fraccion(numerador2 , denominador2);

            Console.WriteLine("Que procedimiento quiere realizar, 0-sumar, 1-restar, 2-multiplicar, 3-dividir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    {
                        fraccion1.sumar(fraccion2);
                        Console.WriteLine("El resultado es: " + fraccion1.getNumerador() + "/" + fraccion1.getDenominador());
                        break;
                    }
                case 1:
                    {
                        fraccion1.restar(fraccion2);
                        Console.WriteLine("El resultado es: " + fraccion1.getNumerador() + "/" + fraccion1.getDenominador());
                        break;
                    }
                case 2:
                    {
                        fraccion1.multiplicar(fraccion2);
                        Console.WriteLine("El resultado es: " + fraccion1.getNumerador() + "/" + fraccion1.getDenominador());
                        break;
                    }
                case 3:
                    {
                        fraccion1.dividir(fraccion2);
                        Console.WriteLine("El resultado es: " + fraccion1.getNumerador() + "/" + fraccion1.getDenominador());
                        break;
                    }
            }



        }

    }
}
