/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 5/4/2025
 * Hora: 18:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	public class FabricaDeAlumnos:FabricaDeComparables
	{
		//EJ 5 practica 3
		//ESTA SI ES LA FABRICA QUE CREA UN COMPARABLE. EN ESTE CASO, ALUMNOS.
		//En todo el sist este es el unico lugar dodne se tiene que encontrar los NEW alumno.
	
		
		public override Comparable crearAleatorio() //Ahora sabe crear un alumno de forma aleatoria
		{
			return new Alumno(gen.stringAleatorio(),gen.numeroAleatorio(10000000),gen.numeroAleatorio(10000),gen.numeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado() //Ahora sabe crear un alumno por teclado.
		{
			return new Alumno(lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
		}
	}
}
