/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 5/4/2025
 * Hora: 17:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	//ej 4 practica 2
	public abstract class FabricaDeComparables
	{
		
		protected GeneradorDeDatosAleatorios gen; //Esto lo pongo en protegido para que todas las subclases puedan utilizar el random sin tener que definir uno nuevo.
		protected LectorDeDatos lec;
		
		public FabricaDeComparables()
		{
			this.gen=new GeneradorDeDatosAleatorios();
			this.lec=new LectorDeDatos();
		}
		
		//ESTE CLASE NO CREA EL COMPARABLE. CREA LA FABRICA QUE CREA EL COMPARABLE
		//METODOS DE CLASE (Son comunes a todas las clases)	
		
		public static Comparable crearAleatorio(int opcion) //Recibe una opcion por las opciones que hay para crear.
		{
			FabricaDeComparables fabrica = null; //Creo una instancia de fabrica que dsp va a ser cambiada segun la fabrica que se quiera.
			
			switch (opcion) { //ACA SOLAMENTE SE CREA LA FABRICA DEPENDIENDO DE QUE SE QUIERA CREAR y en el return se ccrea el comparable
				case 1: //crear numero
					fabrica = new FabricaDeNumeros();break;
					
				case 2: //crear alumno
					fabrica = new FabricaDeAlumnos();break;
				case 3: //crea profesores
					fabrica = new FabricaDeProfesores();break;
				case 4://crear alumno estudioso aleatorio
					fabrica = new FabricaDeAlumnoEstudioso();break;
				case 5://Crea alumnos decorados aleatorios
					fabrica = new FabricaDeAlumnosDecorados();break;
				case 6://Crea alumnos estudiosos decorados aleatorios
					fabrica = new FabricaDeAlumnosEstudiososDecorados();break;	
			}
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion)
		{
		FabricaDeComparables fabrica = null;
		
		switch(opcion)
		{
			case 1://crea numeros por teclado
				fabrica = new FabricaDeNumeros();break;
			case 2: //crea alumnos por teclado
				fabrica = new FabricaDeAlumnos();break;
			case 3: //crea profesores por teclado
				fabrica = new FabricaDeProfesores();break;
			case 4://crear alumno estudioso por teclado
				fabrica = new FabricaDeAlumnoEstudioso();break;
			case 5://Crea alumnos decorados por teclado.
					fabrica = new FabricaDeAlumnosDecorados();break;
		}
		return fabrica.crearPorTeclado();
		}
		
		//METODOS DE INSTANCIA (Se los paso a las subclases para que lo implementen) Son 2 porque tiene que haber 1 para cada metodo estatico. 
		//Este enseña como se crea cada comparable, pero el que lo crea es el creador puntual.
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
		
		
	}
}
