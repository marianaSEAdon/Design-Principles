using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Seleccione el tipo de empleado(1: Tiempo completo, 2: Medio tiempo): ");
            int empleado = Convert.ToInt32(Console.ReadLine());

            Payroll payroll = new Payroll();

            if (empleado == 1)
            {
                Console.WriteLine(payroll.EmpleadoFullTime(340));
            }
            else if (empleado == 2) 
            {
                Console.WriteLine(payroll.EmpleadoPartTime(3, 809));
           
            }
        }
    }
}

///Don't repeat yourself
