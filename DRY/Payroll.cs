using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY
{
    public class Payroll
    {
   

        public decimal CalculateSalary(decimal salary) {

            decimal tax = salary * 0.18m;
            decimal bonus = salary * 0.05m;
            
        return salary - tax + bonus; }

        public decimal EmpleadoFullTime(decimal salary) {

            return CalculateSalary(salary);
        
        }

        public decimal EmpleadoPartTime(decimal salarioPorHora, decimal horas)
        {
            decimal salary = salarioPorHora * horas;

            return CalculateSalary(salary);
        }




    
    }


}
