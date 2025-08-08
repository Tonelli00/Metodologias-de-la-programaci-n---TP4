/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 4/4/2025
 * Hora: 13:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	
	public class CompXDni:PoliticaDeComp
	{
		public bool sosMayor(Alumno A,Alumno B)
		{
			return (A.getDNI()>B.getDNI());
		}
		public bool sosMenor(Alumno A,Alumno B)
		{
			return (A.getDNI()<B.getDNI());
		}
		public bool sosIgual(Alumno A,Alumno B)
		{
			return (A.getDNI()==B.getDNI());
		}
	}
}
