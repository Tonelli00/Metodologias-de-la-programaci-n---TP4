/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 11/4/2025
 * Hora: 14:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	//Todo observador tiene que saber actualizar su estado.
	public interface Observador
	{
		void actualizar(Observado o);
	}
}
