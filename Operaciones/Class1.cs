using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Class1
    //comision de 8 soles retiro: no puede dar monedas ni debe ser negativo
    //comision de deposito 2 soles: se resta a lo que se retira 2 soles de comision
    //maximo puede retirar 500 soles en operacion;
    //maximo de deposito 1000;
    {
        float re, resi, dep, ad;
        float monto = 2000;

        public void retiro()
        {
            Console.WriteLine("Ingrese el monto a retirar (Costo de la comision S/.8)");
            re = float.Parse(Console.ReadLine());
            Console.WriteLine();
            if (re >= 0)
            {
                if (re <= 500)
                {
                    resi = monto - (re + 8);
                    if (resi >= 0)
                    {
                        Console.WriteLine("Se ha retirado: " + re + " mas 8 soles de comisión");
                        Console.WriteLine("El monto actual es: " + resi);
                        monto = resi;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Monto insuficiente");
                    }

                }
                else
                {
                    Console.WriteLine("La operación no puede ser mayor a S/500");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No se puede realizar el retiro, verifique el monto");
            }

        }
        public void saldo()
        {
            Console.WriteLine("El monto actual es:" + monto);
            Console.WriteLine();
        }
        public void deposito()
        {
            Console.WriteLine("Ingrese el monto a depositar (Costo de la comision S/.2)");
            dep = float.Parse(Console.ReadLine());
            Console.WriteLine();
            if (dep >= 0 )
            {
                if (dep <= 1000)
                {
                    ad = monto + (dep - 2);
                    Console.WriteLine("Se ha depositado: " + dep + " menos 2 soles de comisión");
                    Console.WriteLine("El monto actual es: " + ad);
                    Console.WriteLine();
                    monto = ad;
                }
                else
                {
                    Console.WriteLine("La operación no puede ser mayor a S/1000");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No se puede realizar el depósito, verifique el monto");
            }
            
        }
    }
    }
