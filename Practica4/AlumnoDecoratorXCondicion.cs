/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 19/4/2025
 * Hora: 16:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of AlumnoDecoratorXCondicion.
	/// </summary>
	public class AlumnoDecoratorXCondicion:AlumnoDecorator
	{
		public AlumnoDecoratorXCondicion(IAlumno alumno):base(alumno)
		{
		}
		public override string mostrarCalificacion()
		{
			if(base.getCALIFICACION()>=7)
			{
				string texto =base.mostrarCalificacion()+"(PROMOCION)";
				return texto;
			}
			else if(this.getCALIFICACION()>=4 && this.getCALIFICACION()<7)
			{
				string texto = base.mostrarCalificacion()+"(APROBADO)";
				return texto;
			}
			else
			{
			string texto = base.mostrarCalificacion()+"(DESAPROBADO)";
			return texto;
			}
		}
	}
}
