# Trabajo Práctico N°6
------------------
## ¿Qué es String?

String es un tipo de dato inmutable, una clase que permite una manipulacion de cadenas de texto de manera simple y segura. El texto se almacena como un arreglo de caracteres, por lo que podríamos decir que se almacena por referencia.
Es de tipo inmutable, esto quiere decir que una vez creado este mismo no puede ser modificado. Cuando reasignamos un tipo string no lo estamos modificando, sino que se crea un nuevo objeto string y se asigna a esa variable y el valor anterior es liberado.

## Secuencias de escape

| Secuencia de escape  | Nombre del carácter   | Codificación Unicode   |
| ------- | -------- | -------- |
|\\'| Comilla simple |0x0027| 
| \\"|Comilla doble|0x0022|
|\\|Barra diagonal inversa|0x005C|
|\0|Null|0x0000|
|\a|Alerta|0x0007|
|\b|Retroceso|0x0008|
|\f|Avance de página|0x000C|
|\n|Nueva línea|0x000A|
|\r|Retorno de carro|0x000D|
|\t|Tabulación horizontal|0x0009|
|\v|Tabulación vertical|0x000B|
|\u|Secuencia de escape Unicode (UTF-16)|\uHHHH (intervalo: 0000 - FFFF; ejemplo: \u00E7 = "ç")|
|\U|Secuencia de escape Unicode (UTF-32)|\U00HHHHHH (intervalo: 000000 - 10FFFF; ejemplo: \U0001F47D = "👽")|
|\x|Secuencia de escape Unicode similar a "\u" excepto con longitud variable|\xH[H][H][H] (intervalo: 0 - FFFF; ejemplo: \x00E7 o \x0E7 o \xE7 = "ç"|

## Literales de cadenas literales

Agregando un @ antes de la comillas dobles, crearemos algo llamado literales de cadenas literales. Esto nos permite strings de varias lineas
```c#
string saludo = @"Hola
Mundo
";
```

## Interpolación de cadenas.

Las cadenas interpoladaas nos permiten crear cadenas de texto que permiten una concanetación más legible y mantenible. Para crearlas solo es necesario agregar un $ antes de las dobles comillas.
Ej.

```c#
string nombre = "pepe" ;
string saludo = $"Hola {nombre}";
```
