using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using Tarea.Models;

Expresion expresion1 = new Expresion()
{
    num1 = 3,
    num2 = 4,

};

Expresion expresion2 = new Expresion()
{
    num1 = 4,
    num2 = 8,
};

List<Expresion> ListaExpresiones = new List<Expresion>();
ListaExpresiones.Add(expresion1);
ListaExpresiones.Add(expresion2);
    
   foreach(Expresion x in ListaExpresiones)
{

    Console.WriteLine(x.toString());
}
