/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 5/4/2025
 * Hora: 17:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Practicas_MDPI
{
//ej 2 practica 3	
	public class GeneradorDeDatosAleatorios
	{
	 	static Random random = new Random();
		public GeneradorDeDatosAleatorios()
		{
		}
		
		public int numeroAleatorio(int max)
		{
			return random.Next(max);
		}
		public string stringAleatorio() //Este = 5 hace que no sea necesario que le pasen un dato. Ya que por defecto generaria un string de longitud 5.
		{
			List<string> nombres = new List<string>{"Juan", "Maria", "Carlos", "Ana", "Pedro","Laura", "Luis", "Marta", "Fernando", "Isabel","David", "Elena", "Javier", "Raquel", "Sofia", "Andres", "Pablo", "Beatriz", "Victor", "Patricia"};
			int indice = random.Next(0,nombres.Count);
			string nombre = nombres[indice];
			
			return nombre;
		}
	}
}
