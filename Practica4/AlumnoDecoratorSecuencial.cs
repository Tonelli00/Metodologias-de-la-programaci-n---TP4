/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 25/4/2025
 * Hora: 14:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Text;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of AlumnoDecoratorSecuencial.
	/// </summary>
	public class AlumnoDecoratorSecuencial:AlumnoDecorator
	{ 	
		private int valor=1;
		
		public AlumnoDecoratorSecuencial(IAlumno alumno):base(alumno)
		{
			
		}
//		public string mostrarCalificacion()
//		{
//			string texto = this.nombre +"	"+this.calificacion;
//			return texto;
//		}
		public override string mostrarCalificacion() 
		{
			
			
			//1)Ratón Pérez (12345/6) 6	
			string texto=(valor)+")"+base.mostrarCalificacion();
			return texto;
			
		}
	}
}
