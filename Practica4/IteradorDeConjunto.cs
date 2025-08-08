/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 5/4/2025
 * Hora: 14:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	
	public class IteradorDeConjunto:Iterador
	{
		int posAct;
		Conjunto Con;
		public IteradorDeConjunto(Conjunto Conju)
		{
			this.posAct=0;
			this.Con=Conju;
		}
		public void primero(){
			this.posAct=0;	
		}
		public void siguiente(){
			this.posAct++;
		
		}
		public bool fin(){
			return posAct==Con.cuantos();
		
		}
		public Comparable actual(){
			return Con.getElementos(posAct);
		
		}	
	}
}
