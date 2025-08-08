/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 28/3/2025
 * Hora: 17:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practicas_MDPI
{
	//Ejercicio 12 practica 1
	public class Alumno:Persona,Observador,IAlumno
	{
		
		protected int legajo; 
		protected int promedio;
		private int calificacion;
		private PoliticaDeComp politica;
		public Alumno(string nombre,int dni,int l,int p):base(nombre,dni)
		{
			this.legajo=l;
			this.promedio=p;
			this.politica=new CompXNota();
		}
	
	
		public override string getNombre()
		{
			return this.nombre;
		}
		
		public override int getDNI()
		{return this.dni;}
		
		public int getPROMEDIO(){
			return this.promedio;
		}
		
		public int getLEGAJO(){
		return this.legajo;
		}
		public PoliticaDeComp getPOLITICA(){ //Lo hago para comparar a la hora de cambiar la politica en el ejercicio 8 P2.
		return this.politica;
		}
		
		public void SetPolitica(PoliticaDeComp NuevaPolitica)
		{
			this.politica = NuevaPolitica;
		}
		
		public override bool sosMayor(Comparable c)
		{
			return(this.politica.sosMayor(this,(Alumno)c));
		}
		
		public override bool sosMenor(Comparable c)
		{
			return(this.politica.sosMenor(this,(Alumno)c));
		}
		
		public override bool sosIgual(Comparable c)
		{
			return(this.politica.sosIgual(this,(Alumno)c));
		}
		
		public override string ToString(){
			return this.getNombre()+"|LONGITUD NOMBRE:"+this.getNombre().Length+ "|-DNI:"+ this.getDNI()+"|-PROMEDIO:"+this.getPROMEDIO()+ "|-LEGAJO:"+ this.getLEGAJO()+"|-COMPARACION:"+this.getPOLITICA().ToString();
		}
		
		//Ejercicio 11 p3.
		public void prestarAtencion()
		{
			Console.WriteLine("Escuchando al profesor");
		}
		public void distraerse()
		{
			Random rnd = new Random();
			string [] frases = new string[]{"Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
			Console.WriteLine(frases[rnd.Next(0,2)]); //DE ACA ME VA A TIRAR CUALQUIERA DE ESTAS 3 FRASES de forma aleatoria.
		}
		
		//EJERCICIO 1 P4
		public int getCALIFICACION()
		{
			return this.calificacion;
		}
		public void setCalificacion(int Nvacalificacion)
		{
			this.calificacion = Nvacalificacion;
		}
		
		public virtual int responderPregunta(int pregunta){
			Random rnd = new Random();
			return rnd.Next(1,3);
		}
		
		public string mostrarCalificacion()
		{
			string texto = this.nombre +"	"+this.calificacion;
			return texto;
		}
		//FIN EJERCICIO 1 P4
		
		
		
		//Metodos interfaz observador.
		
		public void actualizar(Observado o)
		{
			if(((Profesor)o).isHablando())
			{
				this.prestarAtencion();
			}
			else
			{
				this.distraerse();
			}
		}
		

	}
}
