/*//príma nyereményjáték
Console.Write("Add meg a csoki gyártási számát: ");
int szam=int.Parse(Console.ReadLine());
int oszthatok = 0;
for (int i = 1; i < szam; i++)
{
    if (szam%i==0)
    {
        oszthatok++;
    }
}
if  (oszthatok == 1)
{
    Console.WriteLine("Gratulálok, nyertél!");
}
else
{
    Console.WriteLine("Sajnos nem nyert!");
}


//Páros számok összege
Console.Write("Az intervallom also vegpontja: ");
int also=int.Parse(Console.ReadLine());
Console.Write("Az intervallom felso vegpontja: ");
int felso=int.Parse(Console.ReadLine());
int osszeg = 0;
for  (int i = also; i < felso+1; i++)
{
    if (i % 2 == 0)
    {
        osszeg += i;
    }
}
Console.WriteLine($"A(z) [{also}; {felso}] intervallumba eso paros szamok osszege: {osszeg}");
*/


//szorzótábla
for (int i=1; i<11; i++)
{
    for (int j=1; j<11; j++)
    {
        Console.Write($"{i * j} ");
    }
    Console.Write('\n');
}