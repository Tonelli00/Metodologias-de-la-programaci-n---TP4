/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 19/4/2025
 * Hora: 16:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of AlumnoDecoratorXLegajo.
	/// </summary>
	public class AlumnoDecoratorXLegajo:AlumnoDecorator
	{
		public AlumnoDecoratorXLegajo(IAlumno a): base(a)
		{
		}
//		public string mostrarCalificacion()
//		{
//			string texto = this.nombre +"	"+this.calificacion;
//			return texto;
//		}
		public override string mostrarCalificacion() 
		{
			//Ratón Pérez (12345/6) 6
			string texto = this.getNombre()+" ("+this.getLEGAJO()+")"+this.getCALIFICACION();
			return texto;
		}
	}
}
