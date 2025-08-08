/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 19/4/2025
 * Hora: 16:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of AlumnoDecoratorRecuadro.
	/// </summary>
	public class AlumnoDecoratorRecuadro:AlumnoDecorator
	{
		public AlumnoDecoratorRecuadro(IAlumno alumno):base(alumno)
		{
		}
		//Se le pone base para que se vayan concatenando todas las decoraciones. Porque si uso this se sobreescriben todas las decoracioens anteriores y se trabaja sobre
		//Este alumno puntualmente. En cambio, con el base se trabaja con el alumno base que van heredando todas de la clase alumno decorator.
		public override string mostrarCalificacion()
		{
			string texto=
				"************************************\n" +"*" + base.mostrarCalificacion() +"*\n" + "************************************\n";
			return texto;	
	}
	}
}
