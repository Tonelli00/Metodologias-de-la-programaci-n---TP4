/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 17/4/2025
 * Hora: 19:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	
	public interface IAlumno:Comparable
	{
		string getNombre();
		int getDNI();
		int getPROMEDIO();
		int getCALIFICACION();
		int getLEGAJO();
		string mostrarCalificacion();
       void setCalificacion(int calificacion);
        int responderPregunta(int pregunta);
 
		
		
	}
}
