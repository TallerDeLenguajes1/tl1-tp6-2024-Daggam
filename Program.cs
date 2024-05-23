using System.Linq.Expressions;

int buscarOcurrencia(string cadena, char caracter){
    int contador = 0;
    foreach(char c in cadena){
        if(c==caracter) contador++;
    }
    return contador;
}
void calculadora(int operacion){
    string entrada;
    if(operacion >=1 && operacion <=4){
        decimal a,b;
        Console.WriteLine("Ingrese el primer operando:");
        entrada = Console.ReadLine();
        bool entradaValida = decimal.TryParse(entrada,out a);
        Console.WriteLine("Ingrese el segundo operando:");
        entrada = Console.ReadLine();
        entradaValida = decimal.TryParse(entrada,out b) && entradaValida;
        if(entradaValida){
            switch(operacion){
                case 1:
                    Console.WriteLine("La suma entre "+ a +" y "+ b +" es "+ (a + b).ToString());
                break;
            case 2:
                    Console.WriteLine("La resta de "+ a +" y "+ b +" es "+ (a - b).ToString());
                break;
            case 3:
                    Console.WriteLine("El producto de "+ a +" y "+ b +" es "+ (a * b).ToString());
                break;
            case 4:
                    Console.WriteLine("La division de "+ a +" y "+ b +" es "+ (a / b).ToString());
                break;
            }
        }else{
            Console.WriteLine("Los operandos no son válidos.");
        }
    }else if(operacion >= 5 && operacion <= 10){
        double a;
        Console.WriteLine("Ingrese el operando:");
        entrada = Console.ReadLine();
        bool entradaValida = double.TryParse(entrada,out a);

        if(entradaValida){
            double res;
            switch(operacion){
                case 1:
                    res = double.Abs(a);
                    Console.WriteLine("El valor absoluto de " + a + " es " + res.ToString());
                break;
            case 2:
                    res = a*a;
                    Console.WriteLine("El cuadrado de " + a + " es " + res.ToString());
                break;
            case 3:
                    res = Math.Sqrt(a);
                    Console.WriteLine("La raíz cuadrada de "+ a +" es "+res.ToString());
                break;
            case 4:
                    res = Math.Sin(a);
                    Console.WriteLine("El seno de " + a + " es " + res.ToString());    
                break;
            case 5:
                    res = Math.Cos(a);
                    Console.WriteLine("El coseno de " + a + " es " + res.ToString());    
                break;
            case 6:
                    Console.WriteLine("La parte entera de " + a + " es " + ((int)a).ToString());
                break;
            }
        }else{
            Console.WriteLine("Los operandos no son válidos.");
        }
    }else{
        Console.WriteLine("La operación ingresada no existe.");
    }
}
//Si ingresamos más de una operación, las va ignorar.
void calculadora_expresion(string expresion){
    int indiceOperacion = expresion.IndexOfAny(['+','-','*','/']);
    if(indiceOperacion == -1){
        Console.WriteLine("La expresion dada no es válida");
    }else{
        char primeraOperacion = expresion[indiceOperacion];
        string[] numeros = expresion.Split(primeraOperacion);
        //Corroboramos que los operandos sean válidos.
        float a,b;
        //C# tiene shortcircuit.
        if(float.TryParse(numeros[0].Trim(),out a) && float.TryParse(numeros[1].Trim(),out b) ){
            switch(primeraOperacion){
                case '+':
                    Console.WriteLine("= "+ (a+b).ToString());
                    break;
                case '-':
                    Console.WriteLine("= "+ (a-b).ToString());
                    break;
                case '*':
                    Console.WriteLine("= "+ (a*b).ToString());
                    break;
                case '/':
                    Console.WriteLine("= "+ (a/b).ToString());
                    break;
            }
        }else{
            Console.WriteLine("La expresion ingresada no es válida");
        }
    }
}

Console.WriteLine("Ingrese una cadena de texto: ");
string entrada_1 = Console.ReadLine();
Console.WriteLine("Ingrese otra cadena de texto: ");
string entrada_2 = Console.ReadLine();


Console.WriteLine($"La longitud de la cadena ingresada es de: {entrada_1.Length}");
Console.WriteLine($"La concatenación de la cadena de texto entre la primera entrada y la segunda es: {entrada_1+entrada_2}");
Console.WriteLine($"Subcadena de la primera cadena ingresada desde el indice 3: {entrada_1.Substring(3)}");

Console.WriteLine("--- Calculadora ---");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.WriteLine("5. Valor absoluto");
Console.WriteLine("6. Cuadrado");
Console.WriteLine("7. Raíz Cuadrada");
Console.WriteLine("8. Seno");
Console.WriteLine("9. Coseno");
Console.WriteLine("10. Parte entera");
Console.WriteLine("Ingrese una opción: ");
int opcion;
if(int.TryParse(Console.ReadLine(),out opcion)){
    calculadora(opcion);
}else{
    Console.WriteLine("La opcion seleccionada no es válida.");
}

foreach (char caracter in entrada_1){
    Console.WriteLine(caracter);
}

Console.WriteLine($"La cantidad de veces que aparece el caracter c en la primera cadena de texto ingresada es: {buscarOcurrencia(entrada_1,'c')}");

Console.WriteLine($"Primera cadena de texto ingresada - Todos sus caracteres en mayúscula: {entrada_1.ToUpper()}");
Console.WriteLine($"Primera cadena de texto ingresada - Todos sus caracteres en minúscula: {entrada_1.ToLower()}");

Console.WriteLine("Ingrese un cadena delimitadora para la primera cadena ingresada: ");
string cadena_split = Console.ReadLine();
Console.WriteLine($"Las cadenas delimitadas por {cadena_split} son: ");
foreach(string cadena in entrada_1.Split(cadena_split)){
    Console.WriteLine(cadena);
}
Console.WriteLine("Ingrese una expresión simple para resolver: ");
calculadora_expresion(Console.ReadLine());
