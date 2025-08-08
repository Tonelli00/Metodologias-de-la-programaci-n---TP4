/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 25/4/2025
 * Hora: 15:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of CompXNota.
	/// </summary>
	/// CLASE CREADA PARA HACER EL EJERCICIO 5 OPCIONAL DEL TP 4.
	public class CompXNota:PoliticaDeComp
	{
		
		public bool sosMayor(Alumno A,Alumno B)
		{
			return (A.getCALIFICACION()>B.getCALIFICACION());
		}
		public bool sosMenor(Alumno A,Alumno B)
		{
			return (A.getCALIFICACION()<B.getCALIFICACION());
		}
		public bool sosIgual(Alumno A,Alumno B)
		{
			return (A.getCALIFICACION()==B.getCALIFICACION());
		}
	}
}
