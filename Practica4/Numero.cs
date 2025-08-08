/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 28/3/2025
 * Hora: 12:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{
	//Punto 2 practica 1
	
	public class Numero:Comparable
	{
		//Si numero hereda Comparable SI O SI tiene que implemetar sus metodos. Si es que no los va a usar, le pone un bloque de codigo vacio. PERO SI O SI SE IMPLEMENTAN
		private int valor;
		public Numero(int v)
		{
			this.valor=v;
		}
	
		
		public int getValor()
		{return valor;}
		
		public bool sosMayor(Comparable C)
		{
			return this.valor > ((Numero)C).getValor();
		}
		public bool sosMenor(Comparable C)
		{
			return this.valor < ((Numero)C).getValor();
		}
			
		public bool sosIgual(Comparable C)
		{
			return this.valor == ((Numero)C).getValor();
		}
		public override string ToString() //esto lo que hace es que al ejecutar en vez de mostrar este msj: PRACTICA1_metodologias1.Numero. Nos muestre el valor del objeto 
		{
			return this.valor.ToString();
		}

	}
}
