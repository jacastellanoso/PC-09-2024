//Pide un número entero y el resultado lo declara como "númeroPedido" abreviado
Console.Write("Ingrese un número entero no mayor a 6 cifras: ");
string numeroP = Console.ReadLine();

//Verifica largo y si es mayor a 6 cifras muestra un mensaje de error
if (numeroP.Length > 6)
{
    Console.WriteLine("El número " + numeroP+ " tiene más de 6 cifras. Inténtelo de nuevo.");
    return;
}

//Convierto el "númeroPedido" a un entero para poder hacer el cálculo del "númeroIngresado"
int numeroIng = Convert.ToInt32(numeroP);

//Declaro otra variable como bool sobre el valor si "esPrimo" porque voy a hacer cálculos
bool esPrimo = true;

//Si el númeroIngresado son los negativos o 0 no es primo
if (numeroIng <= 0)
{
    esPrimo = false;
}
/* Si no cumple, se realiza un bucle "for" que itera
 desde 2 hasta numeroIng - 1, si encuentra un divisor se establece
 que "esPrimo" como false y sale del bucle usando "break"*/
else
{
    for (int n = 2; n < numeroIng; n = n + 1)
    {
        if (numeroIng % n == 0)
        {
            esPrimo = false;
            break;
        }
    }
}
//Si esPrimo el resultado se le informa al usuario que si es primo
if (esPrimo)
{
    Console.WriteLine(numeroIng + " es un número primo.");
}
//Sino esPrimo el númeroIngresado se le informa al usuario que no es primo
else
{
    Console.WriteLine(numeroIng + " no es un número primo.");
}