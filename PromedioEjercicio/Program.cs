/*
   Implementa una función, llamada ObtenerMinMaxPromedio, que reciba un arreglo de enteros, y devuelva el valor máximo de dicho arreglo, 
   el valor mínimo, y el valor promedio.

   Para este ejercicio, utilizaremos parámetros out para extraer los tres valores.

   La función devolverá true si el arreglo de enteros tiene al menos un elemento, si tiene cero elementos devolverá false.

   El orden de los parámetros es: int[] numeros, int minimo, int maximo, double promedio

   Nota: debes de colocar out en los parámetros adecuados.
   */

int[] ObtenerMinMaxPromedio(int[] arreglo)
{
	var promedio = 0;
	var resultado = 0;
	var numero = arreglo[0];
	var numeroMenor = arreglo[0];
	for (int i = 0; i < arreglo.Length; i++)
	{
		if(arreglo[i] > numero)
		{
			numero = arreglo[i];
		} else if (arreglo[i] < numeroMenor)
		{
			numeroMenor = arreglo[i];
		}

		promedio += arreglo[i];

		resultado = promedio / arreglo.Length;
		
	}

	return new int[] {numero, numeroMenor, resultado};
}

int[] numeros = ObtenerMinMaxPromedio(new int[] { 10, 99, 4, 55, 66, 100, 88 });


for (int i = 0; i < numeros.Length; i++)
{
	Console.WriteLine($"El numero mayor del arreglo es: {numeros[0]}");
	Console.WriteLine($"El numero menor del arreglo es: {numeros[1]}");
	Console.WriteLine($"El promedio del arreglo es: {numeros[2]}");
	break;
}