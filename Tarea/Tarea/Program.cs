using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using Tarea.Models;

Expresion expresion1 = new Expresion()
{
    num1 = 5,
    num2 = 6,

};

Expresion expresion2 = new Expresion()
{
    num1 = 10,
    num2 = 15,
};

List<Expresion> ListaExpresiones = new List<Expresion>();
ListaExpresiones.Add(expresion1);
ListaExpresiones.Add(expresion2);
    
   foreach(Expresion x in ListaExpresiones)
{

    Console.WriteLine(x.toString());
}
