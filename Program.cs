// See https://aka.ms/new-console-template for more information
// // See https://aka.ms/new-console-template for more information
int opciones;
bool esNumeroValido=true;
string? entrada;

while(true){
    Console.WriteLine("--- Calculadora V2 ---");
    Console.WriteLine("1. Valor absoluto");
    Console.WriteLine("2. Cuadrado");
    Console.WriteLine("3. Raíz Cuadrada");
    Console.WriteLine("4. Seno");
    Console.WriteLine("5. Coseno");
    Console.WriteLine("6. Parte entera");
    Console.WriteLine("Ingrese una opción: ");
    entrada = Console.ReadLine();
    esNumeroValido = int.TryParse(entrada,out opciones);
    if(esNumeroValido){
        if(opciones >= 1 && opciones <= 6){
            double a;
            Console.WriteLine("Ingrese el operando:");
            entrada = Console.ReadLine();
            bool entradaValida = double.TryParse(entrada,out a);

            if(entradaValida){
                double res;
                switch(opciones){
                    case 1:
                        res = double.Abs(a);
                        Console.WriteLine("El valor absoluto de " + a + " es " + res);
                    break;
                case 2:
                        res = a*a;
                        Console.WriteLine("El cuadrado de " + a + " es " + res);
                    break;
                case 3:
                        res = Math.Sqrt(a);
                        Console.WriteLine("La raíz cuadrada de "+ a +" es "+res);
                    break;
                case 4:
                        res = Math.Sin(a);
                        Console.WriteLine("El seno de " + a + " es " + res);    
                    break;
                case 5:
                        res = Math.Cos(a);
                        Console.WriteLine("El coseno de " + a + " es " + res);    
                    break;
                case 6:
                        Console.WriteLine("La parte entera de " + a + " es " + (int)a);
                    break;
                }
                //Después de las operaciones, les pedimos que ingresen dos números.
                double c,d;
                bool valoresValidos;
                Console.WriteLine("Ingrese un numero: ");
                entrada = Console.ReadLine();
                valoresValidos = double.TryParse(entrada,out c);
                Console.WriteLine("Ingrese otro número: ");
                entrada = Console.ReadLine();
                valoresValidos = double.TryParse(entrada,out d) && valoresValidos;

                if(valoresValidos){
                    Console.WriteLine("De los valores ingresados tenemos que:");
                    Console.WriteLine("El máximo es " + Math.Max(c,d));
                    Console.WriteLine("El mínimo es " + Math.Min(c,d));

                }else{
                    Console.WriteLine("Los valores ingresados no son válidos");
                }

            }else{
                Console.WriteLine("Los operandos no son válidos.");
            }
        }else{
            Console.WriteLine("La operación ingresada no existe.");
        }
    }else{
        Console.WriteLine("El valor ingresado no es válido.");
    }
    Console.WriteLine("Ingrese 'S' si desea seguir utilizando la calculadora: ");
    entrada = Console.ReadLine();
    if(entrada != "S") break;
}