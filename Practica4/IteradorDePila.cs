/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 5/4/2025
 * Hora: 13:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	
	public class IteradorDePila:Iterador
	{
		private int posAct;
		private Pila P;
		public IteradorDePila(Pila Pila)
		{
			this.P = Pila; //Porque para poder iterarlo tendria que tener la pila.
			this.posAct=0;
		}
		//Implemento iterador.
		public void primero(){
			this.posAct=0;
		}
		public void siguiente(){
			this.posAct++;
		
		}
		public bool fin(){
			return posAct==P.cuantos();
		}
		public Comparable actual(){
			return P.getElementos(posAct);
		}	
	}
}
