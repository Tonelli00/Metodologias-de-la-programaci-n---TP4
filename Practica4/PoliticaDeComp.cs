/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 4/4/2025
 * Hora: 11:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{

	public interface PoliticaDeComp
	{
		bool sosMayor(Alumno A,Alumno B);
		bool sosMenor(Alumno A,Alumno B);
		bool sosIgual(Alumno A,Alumno B);
	}
}
