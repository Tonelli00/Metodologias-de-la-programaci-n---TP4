using System;

namespace Practicas_MDPI
{
	//Ejercicio 11 practica 1
	public abstract class Persona:Comparable
	{
		protected string nombre;
		protected int dni;
		public Persona(string n,int d)
		{
			this.nombre=n;
			this.dni=d;
	}
//		public string NOMBRE
//		{
//			set{nombre=value;}
//			get{return this.nombre;}
//		}
//		public int DNI
//		{
//			set{dni=value;}
//			get{return this.dni;}
//		}
		
		public abstract string getNombre();
		public abstract int getDNI();
		
		public virtual bool sosMayor(Comparable c)
		{
			return(dni>((Persona)c).getDNI());
		}
		public virtual  bool sosMenor(Comparable c)
		{
			return(this.dni < ((Persona)c).getDNI());
		}
		public virtual bool sosIgual(Comparable c)
		{
		return(dni==((Persona)c).getDNI());
		}
		
		public override string ToString()
		{
			return this.nombre+" "+"DNI-->"+this.dni; //LO HAGO PARA SABER CUALES SON LOS DNI.
		}
		

		
	}
}
