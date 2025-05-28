using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operaciones;

namespace T2_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //cajero de 4 opciones con un while para que solo se muestre hasta el 0
            //comision de 8 soles retiro: no puede dar monedas ni debe ser negativo
            //comision de deposito 2 soles: se resta a lo que se retira 2 soles de comision
            //maximo puede retirar 500 soles en operacion;
            //maximo de deposito 1000;
            //se debe poder ver ver el saldo y usar clases y metodos
            int opcion;
            
            Class1 banco = new Class1();

            Console.WriteLine("Bienvenido/a a su banco, elija la operación que quiere realizar.");
            do
            {
                Console.WriteLine("1.retiro, 2.saldo, 3.deposito, 0.salir ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)

                {

                    case 0:

                        Console.WriteLine("saliendo....");

                        break;

                    case 1:

                        banco.retiro(); ;

                        break;

                    case 2:

                        banco.saldo();

                        break;

                    case 3:

                        banco.deposito();

                        break;

                    default:

                        Console.WriteLine("opcion no valida");

                        break;
                }
            }
            while (opcion !=0);
        }
    }
}
