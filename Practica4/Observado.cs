/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 11/4/2025
 * Hora: 14:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	//El observado es el que sabe notificar a los observadores,agregar y quitar observador. 
	public interface Observado
	{
		void agregar(Observador O);
		void quitar(Observador O);
		void notificar();
		
	}
}
