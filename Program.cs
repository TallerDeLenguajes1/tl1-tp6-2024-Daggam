// See https://aka.ms/new-console-template for more information
string entrada = Console.ReadLine();
int numero = 0;
bool esNumero = int.TryParse(entrada,out numero);

if(esNumero && numero > 0){
    
    int inv=0;
    int aux=0;
    while(numero!=0){
        aux = (numero%10);
        inv = (inv*10) + aux;
        numero/=10;
    }
    Console.WriteLine(inv);
}else{
    Console.WriteLine("La entrada no es válida");
}