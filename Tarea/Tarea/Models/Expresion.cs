using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Models
{
    internal class Expresion
    {

        public int num1 { get; set; }
        public int num2 { get; set; }

        public string toString()
        {
            int sum = this.suma();
            int res = this.resta();
            int div=this.division();
            int mul = this.multiplicacion();
           
            return $" La Suma de los numero es: {sum} \n" +
                   $"La resta del los numero es: {res}\n" +
                   $" La division de los numero es:{div}\n " +
                   $" La multiplicacion de los numero es: {mul}\n";





        }
        public int suma()
        {
            return num1 + num2;
        }

        public int resta()
        {
            return num2 - num1;
        }

        public int division() {
        return num2/ num1;
        }

        public int multiplicacion() { 
            return num1*num2;
        }


    }
}
