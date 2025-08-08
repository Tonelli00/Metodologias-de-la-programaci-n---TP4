/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 4/4/2025
 * Hora: 13:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of CompXProm.
	/// </summary>
	public class CompXProm:PoliticaDeComp
	{
		public bool sosMayor(Alumno A,Alumno B)
		{
			return (A.getPROMEDIO()>B.getPROMEDIO());
		}
		public bool sosMenor(Alumno A,Alumno B)
		{
			return (A.getPROMEDIO()<B.getPROMEDIO());
		}
		public bool sosIgual(Alumno A,Alumno B)
		{
			return (A.getPROMEDIO()==B.getPROMEDIO());
		}
	}
}
