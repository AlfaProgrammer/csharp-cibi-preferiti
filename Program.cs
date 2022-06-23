// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "Pizza", "Pasta al ragù", "Petto di pollo", "Costine", "Riso", "Pasta di riso", "Sushi", "Pasta di soia", "Pesce" };

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

string userInput;

do
{
    Console.Write("Quale è il tuo cibo preferito?: ");

    userInput = Console.ReadLine();

} while (userInput == "");

do {
    Console.WriteLine("Questo cibo non è presente, Insrisci nuovamente: ");
    userInput = Console.ReadLine();

} while (!cibiPreferiti.Contains(userInput));

Random rand = new Random();
int computerNumber = rand.Next(0, cibiPreferiti.Length - 1);

Console.WriteLine($"Stampa Array con le rispettive scelte"); 

loopIndex = 0;

foreach (string item in cibiPreferiti)
{
    if (item == cibiPreferiti[computerNumber] && item == userInput)
    {
        Console.WriteLine($"{item}: -------> Abbiamo gli stessi gusti");
    }    
    else if (item == cibiPreferiti[computerNumber])
    {
        Console.WriteLine($"{item} ------> Scelta Computer");
    }
    else if (item == userInput)
    {
        Console.WriteLine($"{item} ------> Scelta Utente");
    }    
    else
    {
        Console.WriteLine(item);
    }    
}