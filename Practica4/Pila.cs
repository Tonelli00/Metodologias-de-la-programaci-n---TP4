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
	public class Pila:Coleccionable,Iterable //Implementa iterable porque una pila es iterable.
	{
		private List<Comparable>Elementos;
		
		public Pila()
		{
			this.Elementos=new List<Comparable>();
		}
	
		public Comparable getElementos(int indice){
		return (Comparable)this.Elementos[indice];
		}
		
		public void apilar(Comparable C)
		{
			Elementos.Add(C);
		}
		public Comparable desapilar(Comparable C)
		{
			Comparable aux=Elementos[Elementos.Count-1];
			Elementos.Remove(Elementos[Elementos.Count-1]); //El ultimo que llega se va primero.
			return aux;
		}
		
		//Metodos de coleccionable
		public int cuantos()
		{
			return Elementos.Count;
		}
		public Comparable minimo()
		{
			Comparable min_Act=Elementos[0];
			for(int i=1;i<cuantos();i++)
			{
				if((Elementos[i].sosMenor(min_Act)))
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
				if((Elementos[i].sosMayor(max_Act)))
				{
					max_Act=Elementos[i];
				} 
			}
			return max_Act;
		}
		public void agregar(Comparable C)
		{
			apilar(C);
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
		public Iterador crearIterador() //Aca, la pila crea su propio iterador. Que sabe como recorrer pilas
		{
			return new IteradorDePila(this);
		}
	}
}
