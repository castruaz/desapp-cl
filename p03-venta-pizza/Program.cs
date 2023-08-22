// Procesa el pedido de una pizza de acuerdo a la eleccion del usuario

char tam, cub, don;
string tamaño, ingredientes="", cubierta="", donde="";
string[] ings;
float total=0;
int cant=0;

if(args.Length==0) {
    Menu();
    return 1;
}
// Tamano
tam = char.Parse(args[0].ToUpper());
if(tam=='P') { tamaño="Pequeña"; total+=10;}
else if(tam=='M') { tamaño="Mediana"; total+=20;}
else { tamaño="Grande"; total+=30;}
//Ingredientes
ings = args[1].Split('+');
foreach(string i in ings) {
    total+=5;
    switch(char.Parse(i.ToUpper())) {
        case 'E': ingredientes+="Extraqueso ";break;
        case 'C': ingredientes+="Champiñones ";break;
        case 'P': ingredientes+="Piña ";break;
    }
}
// Cubierta y Donde Consume
cub=char.Parse(args[2].ToUpper()); 
cubierta= (cub=='D' ? "Delgada": "Gruesa");
don=char.Parse(args[3].ToUpper());
donde= (don=='A' ? "Aqui": "Llevar");

// Cantidad
cant=int.Parse(args[4]); 
total*=cant;

Console.WriteLine("\nTu pizza queda armada de la siguiente manera");
Console.WriteLine($"Tamaño      : {tamaño}");
Console.WriteLine($"Ingredientes: {ingredientes}");
Console.WriteLine($"Cubierta    : {cubierta}");
Console.WriteLine($"Donde       : {donde}");
Console.WriteLine($"Total   : {total:n2}");
return 0;

static void Menu() {
    Console.Clear();
    Console.WriteLine("Elije como deseas armar tu pedido de pizza \n");
    Console.WriteLine("Tamaño : [P]equeña-$10 [M]ediana-$20 [G]rande-$30");
    Console.WriteLine("Ingredientes : [E]xtra queso [C]hampiñoness [P]iña , unidos por un + ($5)");
    Console.WriteLine("Cubierta : [D]elgada [G]ruesa");
    Console.WriteLine("Donde la consumes : [A]qui [L]levar");
    Console.WriteLine("Cantidad");
}