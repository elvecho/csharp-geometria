// See https://aka.ms/new-console-template for more information


using lamiaclasse;

Console.WriteLine("inserisci la base del rettangolo: ");
int baseR = int.Parse(Console.ReadLine());
Console.WriteLine("inserisci l altezza del rettangolo: ");
int altezzaR = int.Parse(Console.ReadLine());


Rettangolo NuovoRettangolo = new Rettangolo(baseR, altezzaR);

int area = NuovoRettangolo.CalcolaArea(baseR, altezzaR);
Console.WriteLine(area);
int perimetro = NuovoRettangolo.CalcolaPerimetro(baseR, altezzaR);
Console.WriteLine(perimetro);
NuovoRettangolo.StampaRettangolo(perimetro, area);
NuovoRettangolo.disegna();

for(int i = 0; i < 4; i++)
{
    Console.WriteLine("inserisci la base del rettangolo: ");
    int baseR2 = int.Parse(Console.ReadLine());
    Console.WriteLine("inserisci l altezza del rettangolo: ");
    int altezzaR2 = int.Parse(Console.ReadLine());

    Rettangolo rettangolo2 = new Rettangolo(baseR2, altezzaR2);
int area2 = rettangolo2.CalcolaArea(baseR2,altezzaR2);
    
    int perimetro2 = rettangolo2.CalcolaPerimetro(baseR2, altezzaR2);
    rettangolo2.StampaRettangolo(perimetro, area);


}
















