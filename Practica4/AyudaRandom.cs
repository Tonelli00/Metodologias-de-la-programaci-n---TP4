/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 28/3/2025
 * Hora: 17:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Practicas_MDPI
{
	public class AyudaRandom
	{
		private Random random=new Random();
		
		public string seleccionarNombre()
		{
			List<string> nombres = new List<string>{"Juan", "Maria", "Carlos", "Ana", "Pedro","Laura", "Luis", "Marta", "Fernando", "Isabel","David", "Elena", "Javier", "Raquel", "Sofia", "Andres", "Pablo", "Beatriz", "Victor", "Patricia"};
			int indiceAleatorio = random.Next(nombres.Count-1); //Aca genero un indice aleatorio que va a estar entre 0 y el total de la lista
			return nombres[indiceAleatorio];
		}
		public int seleccionarPromedio()
		{
			return random.Next(1,10);
		}
		public int seleccionardni()
		{
			return random.Next(1,105);
		}
	}
}
