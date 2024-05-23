int buscarOcurrencia(string cadena, char caracter){
    int contador = 0;
    foreach(char c in cadena){
        if(c==caracter) contador++;
    }
    return contador;
}

Console.WriteLine("Ingrese una cadena de texto: ");
string entrada_1 = Console.ReadLine();
Console.WriteLine("Ingrese otra cadena de texto: ");
string entrada_2 = Console.ReadLine();


Console.WriteLine($"La longitud de la cadena ingresada es de: {entrada_1.Length}");
Console.WriteLine($"La concatenación de la cadena de texto entre la primera entrada y la segunda es: {entrada_1+entrada_2}");
Console.WriteLine($"Subcadena de la primera cadena ingresada desde el indice 3: {entrada_1.Substring(3)}");

foreach (char caracter in entrada_1){
    Console.WriteLine(caracter);
}

Console.WriteLine($"La cantidad de veces que aparece el caracter c en la primera cadena de texto ingresada es: {buscarOcurrencia(entrada_1,'c')}");

Console.WriteLine($"Primera cadena de texto ingresada - Todos sus caracteres en mayúscula: {entrada_1.ToUpper()}");
Console.WriteLine($"Primera cadena de texto ingresada - Todos sus caracteres en minúscula: {entrada_1.ToLower()}");

Console.WriteLine("Ingrese un cadena: ");
string cadena_split = Console.ReadLine();
Console.WriteLine($"La primera cadena de texto separada por {cadena_split} es: {entrada_1.Split(cadena_split)}");


