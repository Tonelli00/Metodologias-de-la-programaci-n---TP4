/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 6/4/2025
 * Hora: 21:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Practicas_MDPI
{
	
	public class Profesor:Persona,Observado
	{
		private int Antiguedad;
		private bool Hablando;
		private List <Observador>Observadores;
		public Profesor(string n,int d,int ant):base(n,d)
		{
			this.Antiguedad=ant;
			this.Observadores=new List<Observador>();
		}
		//METODOS INTERFAZ PERSONA
		public override bool sosMayor(Comparable c)
		{
			return(this.Antiguedad>((Profesor)c).getANTIGUEDAD());
		}
		public override bool sosMenor(Comparable c)
		{
			return(this.Antiguedad < ((Profesor)c).getANTIGUEDAD());
		}
		public override bool sosIgual(Comparable c)
		{
			return(this.Antiguedad==((Profesor)c).getANTIGUEDAD());
		}
		public override string getNombre()
		{
			return this.nombre;
		}
		public override int getDNI()
		{
			return this.dni;
		}
		
		//cierra metodos de interfaz persona
		
		//METODOS DEL PROFESOR
		public void hablarALaClase()
		{
			Console.WriteLine("Hablando de algun tema.");
			this.Hablando=true;
			notificar();
		}
		public void escribirEnElPizarron()
		{
			Console.WriteLine("Escribiendo en el pizarron...");
			this.Hablando=false;
			notificar();
		}
		public int getANTIGUEDAD()
		{
			return this.Antiguedad;
		}
		public bool isHablando()
		{
			return this.Hablando;
		}
		//CIERRA METODOS DEL PROFESOR
		
	
		
		
		
		
		public override string ToString(){
			return this.getNombre()+"|LONGITUD NOMBRE:"+this.getNombre().Length+ "|-DNI:"+ this.getDNI()+"|ANTIGUEDAD(AÑOS):"+this.getANTIGUEDAD();}
		
		
		//Metodos interfaz observado
		public void agregar(Observador O)
		{
			this.Observadores.Add(O);
		}
		public void quitar(Observador O)
		{
			this.Observadores.Remove(O);
		}
		public void notificar()
		{
			foreach(Observador O in Observadores) //A cada uno de los observadores que tengo los actualizo.
			{
				isHablando();
				O.actualizar(this);
			}
		}
		
		
	}
}
