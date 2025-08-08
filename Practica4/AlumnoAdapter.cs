/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 14/4/2025
 * Hora: 16:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MetodologíasDeProgramaciónI;
namespace Practicas_MDPI
{
	
	public class AlumnoAdapter:Student
	{
		
		
		private IAlumno alumno; //--> Pasa a ser IAlumno para poder trabajar de forma comoda con los decoradores. Porque cuadno implemento los decoradores, el objeto deja de ser de tipo alumno o alumno estudioso
								// y pasa a ser de tipo AlumnoDecorator. Pero, alumno decorator simempre usa un IAlumno. Entonces, hago que alumno adapter use IAlumno para poder usarlo de forma comoda.
		
		public AlumnoAdapter(IAlumno alum)
		{
			this.alumno=alum;
		}
		
		
		public string getName(){
			return alumno.getNombre();
		}
		public IAlumno getALUMNO(){
			return this.alumno;
		}
		
		public int yourAnswerIs(int question){
			return alumno.responderPregunta(question);
		}
		
		public void setScore(int score){
			alumno.setCalificacion(score);
		}
		
		public string showResult(){
			return alumno.mostrarCalificacion();
		}
		
		public bool equals(Student student){
			
			{
				return alumno.sosIgual(((AlumnoAdapter)student).getALUMNO());
			}
			
		}
		
		public bool lessThan(Student student){
			
			return alumno.sosMenor(((AlumnoAdapter)student).getALUMNO());
			
		}
		
		
		public bool greaterThan(Student student){
			
			return alumno.sosMayor(((AlumnoAdapter)student).getALUMNO());
			
		}
		
//		public virtual bool sosMayor(Comparable c)
//		{
//			return(alumno.sosMayor(((AlumnoAdapter)c).alumno));
//		}
//		public virtual  bool sosMenor(Comparable c)
//		{
//			return(alumno.sosMenor(((AlumnoAdapter)c).alumno));
//		}
//		public virtual bool sosIgual(Comparable c)
//		{
//		return(alumno.sosIgual(((AlumnoAdapter)c).alumno));
//		}
		
	}
}
