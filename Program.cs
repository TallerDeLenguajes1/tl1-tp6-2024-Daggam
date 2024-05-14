// See https://aka.ms/new-console-template for more information
int opciones=0;
bool esNumero;
string entrada;
do{
    Console.WriteLine("--- Calculadora V1 ---");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Restar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("Ingrese un numero: ");
    entrada = Console.ReadLine();
    esNumero = int.TryParse(entrada,out opciones);
    if(esNumero && (opciones < 1 || opciones >4)){
        Console.WriteLine("Ingrese operando validos.");
    }else{
        int a,b;
        bool ab,bb;
        
        Console.WriteLine("Ingrese el primer operando: ");
        entrada = Console.ReadLine();
        ab = int.TryParse(entrada,out a);
        
        Console.WriteLine("Ingrese el segundo operando: ");
        entrada = Console.ReadLine();
        bb = int.TryParse(entrada,out b);


        if(ab && bb){
            int res;
            switch(opciones){
                case 1:
                    res = a + b;
                    Console.WriteLine("La suma de "+ a +" y "+ b +"es "+ res);
                    break;
                case 2:
                    res = a - b;
                    Console.WriteLine("La resta de "+ a +" y "+ b +"es "+ res);
                    break;
                case 3:
                    res = a * b;
                    Console.WriteLine("El producto de "+ a +" y "+ b +"es "+ res);
                    break;
                case 4:
                    res = a / b;
                    Console.WriteLine("La division de "+ a +" y "+ b +" es "+ res);
                    break;
            }
        }
    }
    // if(esNumero && (opciones >= 1 || opciones<=4)){
    //     int a,b;
    //     bool ab,bb;
    //     Console.WriteLine("Ingrese el primer operando:");
    //     entrada = Console.ReadLine();
    //     ab = int.TryParse(entrada,out a);
    //     Console.WriteLine("Ingrese el segundo operando:");
    //     entrada = Console.ReadLine();
    //     bb = int.TryParse(entrada,out b);
    //     if( ab && bb){
    //         switch(opciones){
    //             case 1:  
    //                 Console.WriteLine(a+b);
    //                 break;
    //         }

    //     }else{
    //         Console.WriteLine("Ingrese operando validos.");
    //     }
    // }else{
    //     Console.WriteLine("Ingrese valores validos.");
    // }
    
}while(esNumero && (opciones < 1 || opciones >4));

