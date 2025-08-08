/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 4/4/2025
 * Hora: 17:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();	
	}
}
