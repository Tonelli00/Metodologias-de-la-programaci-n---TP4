/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 14/4/2025
 * Hora: 15:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{

	public class AlumnoMuyEstudioso:Alumno,IAlumno
	{
		
		public AlumnoMuyEstudioso(string nombre,int dni,int l,int p):base(nombre,dni,l,p)
		{
		}
		
		public override int responderPregunta(int pregunta)
		{
			return pregunta % 3;
		}
	}
}
