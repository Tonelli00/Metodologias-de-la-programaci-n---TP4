/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 5/4/2025
 * Hora: 13:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	
	public class IteradorDeCola:Iterador
	{
		private int posAct;
		private Cola C;
		
		public IteradorDeCola(Cola Co)
		{
			this.C=Co;
			this.posAct=0;
		}
	
		public void primero(){
			this.posAct=0;
		}
		public void siguiente(){
			this.posAct++;
		}
		public bool fin(){
			return this.posAct==C.cuantos();
		
		}
		public Comparable actual(){
			return C.getElementos(posAct);
		}	
	}
}
