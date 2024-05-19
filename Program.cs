// // See https://aka.ms/new-console-template for more information
int opciones;
bool esNumeroValido=true;
string? entrada;

while(true){
    Console.WriteLine("--- Calculadora V1 ---");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("Ingrese un numero: ");
    entrada = Console.ReadLine();
    esNumeroValido = int.TryParse(entrada,out opciones);
    if(esNumeroValido){
        if(opciones >= 1 && opciones <= 4){
            Console.WriteLine("Ingrese el primer operando:");
            decimal a,b;
            entrada = Console.ReadLine();
            bool entradaValida = decimal.TryParse(entrada,out a);
            Console.WriteLine("Ingrese el segundo operando:");
            entrada = Console.ReadLine();
            entradaValida = decimal.TryParse(entrada,out b) && entradaValida;

            if(entradaValida){
                decimal res;
                switch(opciones){
                    case 1:
                        res = a + b;
                        Console.WriteLine("La suma de "+ a +" y "+ b +" es "+ res);
                    break;
                case 2:
                        res = a - b;
                        Console.WriteLine("La resta de "+ a +" y "+ b +" es "+ res);
                    break;
                case 3:
                        res = a * b;
                        Console.WriteLine("El producto de "+ a +" y "+ b +" es "+ res);
                    break;
                case 4:
                        res = a / b;
                        Console.WriteLine("La division de "+ a +" y "+ b +" es "+ res);
                    break;
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

// int opciones=0;
// bool esNumero;
// string entrada;
// do{
//     Console.WriteLine("--- Calculadora V1 ---");
//     Console.WriteLine("1. Sumar");
//     Console.WriteLine("2. Restar");
//     Console.WriteLine("3. Multiplicar");
//     Console.WriteLine("4. Dividir");
//     Console.WriteLine("Ingrese un numero: ");
//     entrada = Console.ReadLine();
//     esNumero = int.TryParse(entrada,out opciones);
//     if(esNumero && (opciones < 1 || opciones >4)){
//         Console.WriteLine("Ingrese operando validos.");
//     }else{
//         int a,b;
//         bool ab,bb;
        
//         Console.WriteLine("Ingrese el primer operando: ");
//         entrada = Console.ReadLine();
//         ab = int.TryParse(entrada,out a);
        
//         Console.WriteLine("Ingrese el segundo operando: ");
//         entrada = Console.ReadLine();
//         bb = int.TryParse(entrada,out b);

//         if(ab && bb){
//             int res;
//             switch(opciones){
//                 case 1:
//                     res = a + b;
//                     Console.WriteLine("La suma de "+ a +" y "+ b +" es "+ res);
//                     break;
//                 case 2:
//                     res = a - b;
//                     Console.WriteLine("La resta de "+ a +" y "+ b +" es "+ res);
//                     break;
//                 case 3:
//                     res = a * b;
//                     Console.WriteLine("El producto de "+ a +" y "+ b +" es "+ res);
//                     break;
//                 case 4:
//                     res = a / b;
//                     Console.WriteLine("La division de "+ a +" y "+ b +" es "+ res);
//                     break;
//             }
//         }
//         Console.WriteLine("¿Desea realizar otro cálculo? (S: sí; cualquier otra tecla: no): ");
//         entrada = Console.ReadLine();
//         if( entrada == "y") opciones = -11; //Pongo opciones -11 por que no quiero crear otra variable para continuar.
//     }
// }while(esNumero && (opciones < 1 || opciones >4));

