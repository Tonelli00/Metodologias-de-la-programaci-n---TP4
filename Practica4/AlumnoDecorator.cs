/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 19/4/2025
 * Hora: 16:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public abstract class AlumnoDecorator:IAlumno
	{
		IAlumno alumno;
		public AlumnoDecorator(IAlumno a)
		{
			this.alumno = a ;
		}
		//Implemento IAlumno 
		public  string getNombre(){
			return this.alumno.getNombre();
		}
		public  int getDNI(){
			return this.alumno.getDNI();
		}
		public  int getPROMEDIO(){
			return this.alumno.getPROMEDIO();
		}
		public  int getCALIFICACION(){
			return this.alumno.getCALIFICACION();
		}
		public  int getLEGAJO()
		{
			return this.alumno.getLEGAJO();
		}
		public void setCalificacion(int calificacion)
		{
			this.alumno.setCalificacion(calificacion);
		}
		public int responderPregunta(int pregunta)
		{
			return this.alumno.responderPregunta(pregunta);
		}

		
		public virtual string mostrarCalificacion()
		{
			return this.alumno.mostrarCalificacion();
		}
		
		public bool sosMayor(Comparable c)
		{
			return alumno.sosMayor(((AlumnoDecorator)c).alumno); 
		}
		
		public  bool sosMenor(Comparable c)
		{
			return alumno.sosMenor(((AlumnoDecorator)c).alumno);
		}
		
		public  bool sosIgual(Comparable c)
		{
			return alumno.sosIgual(((AlumnoDecorator)c).alumno);
		}
		
	
	}
}
