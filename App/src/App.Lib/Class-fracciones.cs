//using static Newtonsoft.Json.JsonConvert;
using static System.Text.Json.JsonSerializer;

using System;

namespace fracciones
{
    public class Fraccion
    {
    private int numerador;
	private int denominador;

	//CONTRUCTOR
	public Fraccion(int numerador, int denominador ) {
		this.numerador = numerador;
		this.denominador = denominador;
	}
	
	
	
	//METODOS GET Y SET
	public int getNumerador() {
		return numerador;
	}


	public void setNumerador(int numerador) {
		this.numerador = numerador;
	}


	public int getDenominador() {
		return denominador;
	}


	public void setDenominador(int denominador) {
		this.denominador = denominador;
	}

	//METODOS DE SUMA RESTA MULTIPLICACION Y DIVISION
	public string sumar (Fraccion fraccion2) {
		
		this.numerador = (this.numerador * fraccion2.denominador) + (this.denominador * fraccion2.numerador);
		this.denominador = this.denominador * fraccion2.denominador;
		return this.numerador + "/" + this.denominador;
	}

	public string restar (Fraccion fraccion2) {
		this.numerador = (this.numerador * fraccion2.denominador) - (this.denominador * fraccion2.numerador);
		this.denominador = this.denominador * denominador;
		return this.numerador + "/" + this.denominador;
	}

	public string multiplicar (Fraccion fraccion2) {
		this.numerador = this.numerador * fraccion2.numerador;
		this.denominador = this.denominador * fraccion2.denominador;
		return this.numerador + "/" + this.denominador;
	}

	public string dividir (Fraccion fraccion2) {
		this.numerador = this.numerador * fraccion2.denominador;
		this.denominador = this.denominador * fraccion2.numerador;
		return this.numerador + "/" + this.denominador;
	}
    }
}
