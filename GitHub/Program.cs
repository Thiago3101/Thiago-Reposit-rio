Console.WriteLine("--------------------------");
Console.WriteLine("[1] - Saudação.");
Console.WriteLine("--------------------------");

Console.Write("\nEscolha uma opção: ");
int opc = Convert.ToInt32(Console.ReadLine());

if(opc == 1)
{
    Console.WriteLine("\nQual seu nome?");
    string nome = Console.ReadLine();
    Console.WriteLine($"\nOlá, {nome}!");
}