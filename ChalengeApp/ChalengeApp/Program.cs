// Werner Wxxx
// Zadanie Domowe Dzień 4

string imie = "Ewa";
string plec = "Kobieta";
int wiek = 33;

if (plec == "Kobieta")
{
    if (wiek < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (wiek >= 33 && imie == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (wiek < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
