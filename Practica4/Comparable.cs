/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 28/3/2025
 * Hora: 12:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	//PUNTO 1 PRACTICA 1
	public interface Comparable
	{ //Como es una interfaz, los metodos se declaran sin codigo. El codigo se lo da la clase que lo utilice.
		bool sosMayor(Comparable c);
		bool sosMenor(Comparable c);
		bool sosIgual(Comparable c);
	}
}
