/*
 * Creado por SharpDevelop.
 * Usuario: tonel
 * Fecha: 5/4/2025
 * Hora: 18:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas_MDPI
{

	public class FabricaDeNumeros:FabricaDeComparables
	{
		//EJ 5 Practica 3
		//ESTA SI ES LA FABRICA QUE CREA UN COMPARABLE. EN ESTE CASO, numeros.
		//En todo el sist este es el unico lugar dodne se tiene que encontrar los NEW numero.
		
		public override Comparable crearAleatorio()
		{
			return new Numero(gen.numeroAleatorio(1000));
		}
		public override Comparable crearPorTeclado()
		{
			return new Numero(lec.numeroPorTeclado());
		}
		
	}
}
