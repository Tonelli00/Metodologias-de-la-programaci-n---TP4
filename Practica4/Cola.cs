/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 28/3/2025
 * Hora: 14:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Practicas_MDPI
{
	//Punto 4 practica 1
	public class Cola:Coleccionable,Iterable
	{
		private List<Comparable>Elementos;
		public Cola()
		{
			this.Elementos=new List<Comparable>();
		}
		public Comparable getElementos(int indice){
			return (Comparable)this.Elementos[indice];
		}
		public void Encolar(Comparable C)
		{
			Elementos.Add(C);
		}
		public Comparable Desencolar()
		{
			Comparable Aux = Elementos[0]; //Porque en una cola el primero que llega se va primero
			Elementos.Remove(Elementos[0]);
			return Aux;
		}
		

		public int cuantos()
		{
			return this.Elementos.Count;
		}
		public Comparable minimo()
		{
			Comparable min_Act=Elementos[0];
			for(int i=1;i<cuantos();i++)
			{
				if(Elementos[i].sosMenor(min_Act))
				{
					min_Act=Elementos[i];
				}
			}
			return min_Act;
		}
		public Comparable maximo()
		{
			Comparable max_Act=Elementos[0];
			for(int i=1;i<cuantos();i++)
			{
				if(Elementos[i].sosMayor(max_Act))
				{
					max_Act=Elementos[i];
				}
			}
			return max_Act;
		}
		public void agregar(Comparable C)
		{
			Encolar(C);
		}
		public bool contiene(Comparable C)
		{	
			
			for(int i=0;i<cuantos();i++)
			{
				if(Elementos[i].sosIgual(C))
				{
					return true;
				}
			}
			return false;
		}
		//Metodos de iterable
		public Iterador crearIterador()
		{
			return new IteradorDeCola(this);
		}
		
		
	}
}
