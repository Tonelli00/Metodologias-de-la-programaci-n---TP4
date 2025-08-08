/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 28/3/2025
 * Hora: 12:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	//PUNTO 3 practica 1
	public interface Coleccionable
	{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable C);
		bool contiene(Comparable C);
		}
}
