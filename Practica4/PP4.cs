/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 28/3/2025
 * Hora: 12:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using MetodologíasDeProgramaciónI;
namespace Practicas_MDPI
{
	class Program
	{
		//Decorator y adapter.
		
		public static void Main(string[] args)
		{
			
			
			//EJ 4 P4
			darClases();
			//FIN EJ 4 P4
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
			
	
		
		
		public static void darClases()
		{
		//EJERCICIO 4 P5
			Teacher teacher = new Teacher();
			
			for(int i = 1 ; i<=10 ; i++)
			{
				IAlumno alum=(IAlumno)FabricaDeComparables.crearAleatorio(6);
				Student student = new AlumnoAdapter(alum);
				
				teacher.goToClass(student);	
			}
			for(int i = 11 ; i<=20 ; i++)
			{
				IAlumno alum=(IAlumno)FabricaDeComparables.crearAleatorio(5);
				Student student2 = new AlumnoAdapter(alum);
			
				teacher.goToClass(student2);	
			}

			teacher.teachingAClass();
			//FIN EJERCICIO 4 P5
		
	}
}
}
