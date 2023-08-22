// Calcula la paga de un trabajador, considerando las hora extra

string nombre="";
int horas=0, hextra=0;
float paga=0, pagaextra=0, pagabruta=0, paganeta=0, impuesto=0, tasa=0;
// Entrada
Console.Clear();
Console.Write("Nombre ? "); nombre = Console.ReadLine();
Console.Write("Horas  ? "); horas = int.Parse(Console.ReadLine());
Console.Write("Paga   ? "); paga = float.Parse(Console.ReadLine());
// Calculos
tasa=0.03f;

if(horas>40) {
    hextra = horas - 40;
    pagaextra = 2 * paga * hextra ;
    pagabruta = 40 * paga + pagaextra;
} else 
    pagabruta = horas * paga;

impuesto = pagabruta * tasa;
paganeta = pagabruta - impuesto;
// Salida
Console.WriteLine($"\nResumen de pagos del trabajador {nombre} \n");
Console.WriteLine($"{horas} horas trabajadas, {hextra} extra, paga {paga}, tasa de impuesto {tasa:p2}");
Console.WriteLine($"Paga Bruta : {pagabruta,12:c2}");
Console.WriteLine($"Paga Extra : {pagaextra,12:c2}");
Console.WriteLine($"Impuesto   : {impuesto,12:c2}");
Console.WriteLine($"Paga Neta  : {paganeta,12:c2}");

