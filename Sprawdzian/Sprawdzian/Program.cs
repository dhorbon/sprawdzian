using Sprawdzian;

Pracownik p1 = new Pracownik("Jan", "Kowalski");
Pracownik p2 = new Pracownik("Janina", "Kowalska");

p1.StartPracy();
p2.StartPracy();

p2.StopPracy();

ZakladPracy z = new ZakladPracy("A.S. Bytom");

z.Pracownicy.Add(p1);
z.Pracownicy.Add(p2);

Console.WriteLine("Wszyscy: ");
z.WyswietlWszystkich();

Console.WriteLine("Ci, co zakończyli prace: ");
z.WyswietlZakonczonych();