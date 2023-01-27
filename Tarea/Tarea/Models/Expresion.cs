using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Models
{
    internal class Expresion
    {

        public double num1 { get; set; }
        public double num2 { get; set; }

        public string toString()
        {
            double sum = this.suma();
            double res = this.resta();
            double div=this.division();
            double mul = this.multiplicacion();
            double may=this.mayor();
            double men = this.menor();

            return $" La Suma de los numero es: {sum}\n" +
                   $" La resta del los numero es: {res}\n" +
                   $" La division de los numero es: {div}\n" +
                   $" La multiplicacion de los numero es: {mul}\n" +
                   $" El numero mayo es:{may}\n" +
                   $" El numero menos es:{men}";





        }
        public double suma()
        {
            return num1 + num2;
        }

        public double resta()
        {
            return num2 - num1;
        }

        public double division() {
        return num2/ num1;
        }

        public double multiplicacion() { 
            return num1*num2;
        }

        public double mayor()

        {
            if (num1 > num2)
            {
                return num1;
            }else 
                return num2;
        }

        public double menor()

        {
            if (num1 < num2)
            {
                return num1;
            }
            else
                return num2;
        }

    }
}
