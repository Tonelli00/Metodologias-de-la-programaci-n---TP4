/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 4/4/2025
 * Hora: 14:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of CompXNombre.
	/// </summary>
	public class CompXNombre:PoliticaDeComp
	{
		public bool sosMayor(Alumno A,Alumno B)
		{
			return (A.getNombre().Length>B.getNombre().Length); //Comparo por longitud de nombre
		}
		public bool sosMenor(Alumno A,Alumno B)
		{
			return (A.getNombre().Length<B.getNombre().Length); //Comparo por longitud de nombre
		}
		public bool sosIgual(Alumno A,Alumno B)
		{
			return (A.getNombre().Length == B.getNombre().Length); //Comparo por longitud de nombre
		}
	
	}
}
