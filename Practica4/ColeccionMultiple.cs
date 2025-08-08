/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 28/3/2025
 * Hora: 16:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	//Ejercicio 8 practica 1
	public class ColeccionMultiple:Coleccionable
	{
		private Pila pila;
		private Cola cola;
		public ColeccionMultiple(Pila p,Cola c)
		{
			this.pila=p;
			this.cola=c;
		}
		public int cuantos()
		{
			return (pila.cuantos()+cola.cuantos());
		}
		public Comparable minimo()
		{
			Comparable var1=pila.minimo();
			Comparable var2=cola.minimo();
			if(((Alumno)var1).getDNI()>((Alumno)var2).getDNI())
			{
				return var1;
			}
			else
			{return var2;}
		}
		public Comparable maximo()
		{
			Comparable var1=pila.maximo();
			Comparable var2=cola.maximo();
			if(((Alumno)var1).getDNI()>((Alumno)var2).getDNI())
			{
				return var1;
			}
			else
			{return var2;}
		}
		public void agregar(Comparable C){}
		
		public bool contiene(Comparable C)
		{
			return (pila.contiene(C)||cola.contiene(C));
		}
		
}
}