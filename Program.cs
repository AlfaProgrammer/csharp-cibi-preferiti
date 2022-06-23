// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "Pizza", "Pasta al ragù", "Petto di pollo", "Costine", "Riso" };

int arrLength = cibiPreferiti.Length;

Console.WriteLine($"Lunghezza elenco: {arrLength}");
Console.WriteLine($"Primo cibo in classifica: {cibiPreferiti[0]}");
Console.WriteLine($"Ultimo cibo in classifica: {cibiPreferiti[arrLength - 1]}");

int loopIndex = 0;

Console.WriteLine("Sotto trovi l'intera classifica");

foreach (string item in cibiPreferiti) {
    Console.WriteLine($"Posizione: {loopIndex + 1}, piatto: {item}");
    loopIndex++;
}

Console.WriteLine("Cibo di mezza classifica");

for (int i = 1; i < cibiPreferiti.Length - 1 ; i++)
{
    Console.WriteLine ($"Index: {i}, cibo: {cibiPreferiti[i]}");
}