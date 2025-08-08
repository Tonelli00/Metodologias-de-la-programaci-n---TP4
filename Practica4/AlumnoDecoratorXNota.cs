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
	/// Description of AlumnoDecoratorXNota.
	/// </summary>
	public class AlumnoDecoratorXNota:AlumnoDecorator
	{
		public AlumnoDecoratorXNota(IAlumno alumno):base(alumno)
		{
		}
		public override string mostrarCalificacion()
		{
			string textobase=base.mostrarCalificacion();
			string nota="";
			switch (this.getCALIFICACION())
			{
				case 0:
					nota="(CERO)";
					break;
				case 1:
					nota="(UNO)";
					break;
				case 2:
					nota="(DOS)";
					break;
				case 3:
					nota="(TRES)";
					break;
				case 4:
					nota="(CUATRO)";
					break;
				case 5:
					nota="(CINCO)";
					break;
				case 6:
					nota="(SEIS)";
					break;
				case 7:	
					nota="(SIETE)";
					break;
				case 8:
					nota="(OCHO)";
					break;
				case 9:
					nota="(NUEVE)";
					break;
				case 10:
					nota="(DIEZ)";
					break;
			}
			return textobase+" "+nota;
		}
	}
}
