/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 5/4/2025
 * Hora: 17:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	//Ej 2 practica 3	
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		public int numeroPorTeclado()
		{
			Console.WriteLine("Ingrese un numero:");
			return int.Parse(Console.ReadLine());
		}
		public string stringPorTeclado()
		{
			Console.WriteLine("Ingrese un texto:");
			return Console.ReadLine();
		}
		
	}
}
