/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 9/5/2025
 * Hora: 17:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of FabricaDeAlumnosEstudiososDecorados.
	/// </summary>
	public class FabricaDeAlumnosEstudiososDecorados:FabricaDeComparables
	{
		public override Comparable crearAleatorio() //Ahora sabe crear un alumno de forma aleatoria
		{
			IAlumno Alumno_Decorado =  new AlumnoMuyEstudioso(gen.stringAleatorio(),gen.numeroAleatorio(10000000),gen.numeroAleatorio(10000),gen.numeroAleatorio(10));
			Alumno_Decorado=new AlumnoDecoratorXLegajo(Alumno_Decorado);
			Alumno_Decorado=new AlumnoDecoratorXNota(Alumno_Decorado);
			Alumno_Decorado=new AlumnoDecoratorXCondicion(Alumno_Decorado);
			Alumno_Decorado=new AlumnoDecoratorRecuadro(Alumno_Decorado);
			return Alumno_Decorado;
		}
		public override Comparable crearPorTeclado() //Ahora sabe crear un alumno por teclado.
		{
			return new AlumnoMuyEstudioso(lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
		}
	}
}
