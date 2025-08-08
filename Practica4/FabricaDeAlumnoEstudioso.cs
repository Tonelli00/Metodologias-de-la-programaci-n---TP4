/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 14/4/2025
 * Hora: 17:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of FabricaDeAlumnoEstudioso.
	/// </summary>
	public class FabricaDeAlumnoEstudioso:FabricaDeComparables
	{
		//Lo creo yo para poder hacer mas facil la creacion de 10 alumnos estudiosos.
		public override Comparable crearAleatorio() //Ahora sabe crear un alumno  estudioso de forma aleatoria
		{
			return new AlumnoMuyEstudioso(gen.stringAleatorio(),gen.numeroAleatorio(10000000),gen.numeroAleatorio(10000),gen.numeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado() //Ahora sabe crear un alumno estudioso por teclado.
		{
			return new AlumnoMuyEstudioso(lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
		}	
	}
}
