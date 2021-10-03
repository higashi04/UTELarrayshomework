using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Arreglo
{
    class Arreglo
    {
int[] edades;
public void recibe()
{
 edades = new int[10];
          	 for (int i = 0; i< edades.Length; i++)
           	 {
            	    Console.Write("Ingrese la edad: "+(i+1)+": ");
             	    edades[i] = int.Parse(Console.ReadLine());
		  }
		Console.Write("Calculando el promedio… ");
        //INGRESA AQUÍ TU CÓDIGO
        int sum = edades.Sum(); // se declara una variable de tipo entero que equivale al arreglo edades con el metodo Sum(), el cual suma los contenidos del arreglo.
        int average = sum / edades.Length; // Para calcular el promedio, se toma la variable donde se suman las edades y se divide entre la cantidad de elementos
                                          //dentro del arreglo, usando la sentencia Length.
        Console.WriteLine("El promedio de edades es " + average);
        //Fin de mi código.
           	  
}

static void Main(string[] args)
         {
                    Arreglo alumnos=new Arreglo();
		alumnos.recibe();
Console.ReadKey();
            }
        
            
        }
}
