/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 4/4/2025
 * Hora: 16:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Practicas_MDPI
{
	
	public class Conjunto:Coleccionable,Iterable
	{
		List <Comparable>Elementos;
		public Conjunto()
		{
			this.Elementos=new List<Comparable>();
		}
		
		public Comparable getElementos(int indice){
			return (Comparable)this.Elementos[indice];
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
			if(!pertenece(C))
			{
				Elementos.Add(C);
			}
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
		
		public bool pertenece(Comparable C)
		{
			return contiene(C);
		}
		//Metodos de iterable
		public Iterador crearIterador()
		{
			return new IteradorDeConjunto(this);
		}
	}
}
