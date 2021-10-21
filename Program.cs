/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 20-10-2021
 * Hora: 08:42 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio01_corte1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Este es el primer ejercicio práctico del corte 1.");
			
			Console.WriteLine(" ");
			
			Console.WriteLine("Para éste ejercicio se debe mostrar tres números ");
			Console.WriteLine("formados por tres variables numéricas en diferentes combinaciones. ");
			
			Console.WriteLine(" ");
			
			Console.WriteLine("Por favor, presiona una tecla para continuar...");
			Console.ReadKey(true);
			Console.WriteLine(" ");
			
			Console.WriteLine("Las variables a utilizar son: ");
			Console.WriteLine(" a: 7");
			Console.WriteLine(" b: 1");
			Console.WriteLine(" c: 3");
			
			//Declaración de las variables
				int a, b, c;
			//Inicialización de las variables
					a = 7;
					b = 1;
					c = 3;
			
			Console.WriteLine(" ");
			
			Console.WriteLine(" Las combinaciones son:");
			Console.WriteLine(" 1.aacb    2.bca    3.bcbc");
			Console.WriteLine(" ");
			
			
					//Empieza la primera combinación  aacb
			
			Console.WriteLine(" ");
			Console.WriteLine("Presiona una tecla para ver la primera combinación...");
			Console.ReadKey(true);
			Console.WriteLine(" ");
			
			Console.Write("Combinación  aacb: ");
			Console.Write(" ");
			Console.Write(a);
			Console.Write(a);
			Console.Write(c);
			Console.Write(b);
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			
			
					//Empieza la segunda combinación  bca
			
			Console.WriteLine(" ");
			Console.WriteLine("Presiona una tecla para ver la segunda combinación...");
			Console.ReadKey(true);
			Console.WriteLine(" ");
			
			Console.Write("Combinación  bca: ");
			Console.Write(" ");
			Console.WriteLine(+a +b +c);
			Console.Write(" ");
			Console.Write(b);
			Console.Write(c);
			Console.Write(a);
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			
			
					//Empieza la tercera combinación  bcbc
			
			Console.WriteLine(" ");
			Console.WriteLine("Presiona una tecla para ver la tercera combinación...");
			Console.ReadKey(true);
			Console.WriteLine(" ");
			
			Console.Write("Combinación  bcbc: ");
			Console.Write(" ");
			Console.Write(b);
			Console.Write(c);
			Console.Write(b);
			Console.Write(c);
			Console.WriteLine(" ");
			
			
			Console.WriteLine(" ");
			Console.WriteLine("Gracias.");
			
			Console.ReadKey(true);
		}
	}
}