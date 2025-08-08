/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 11/4/2025
 * Hora: 12:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores:FabricaDeComparables
	{	// Ejercicio 9 de la practica 3.
		
		
		public override Comparable crearAleatorio() //Ahora sabe crear un profesor de forma aleatoria
		{
			return new Profesor(gen.stringAleatorio(),gen.numeroAleatorio(10000000),gen.numeroAleatorio(7));
		}
		
		public override Comparable crearPorTeclado() //Ahora sabe crear un profesor por teclado.
		{
			return new Profesor(lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
		}
	}
}
