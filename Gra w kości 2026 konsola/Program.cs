public class kosc
{
    private static readonly Random _random = new Random();
    public static int liczbaInstancji = 0;
    public String[] nazwyplikow = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"};
    public int LiczbaOczek;
    public int index;
    public bool dostepna;

    public kosc(int wartosc)
    {
        if (wartosc < 1 || wartosc > 6) {
            wartosc = 0;
        }
        this.LiczbaOczek = wartosc;
        this.index = wartosc;
        this.dostepna = true;
        liczbaInstancji++;
    }
    public kosc()
    {
        int wylosowanaLiczba = _random.Next(1, 7);

        this.LiczbaOczek = wylosowanaLiczba;
        this.index = wylosowanaLiczba;

        this.dostepna = true;

        liczbaInstancji++;
    }

    public void RzucKosc()
    {
        if (this.dostepna)
        {
            int wylosowanaWartosc = _random.Next(1, 7);
            this.LiczbaOczek = wylosowanaWartosc;
            this.index = wylosowanaWartosc;
        }
    }

    public void BlokujKosc()
    {
        this.dostepna = false;
    }

    public string PobierzWartoscTekstowo()
    {
        switch (this.LiczbaOczek)
        {
            case 1: return "jeden";
            case 2: return "dwa";
            case 3: return "trzy";
            case 4: return "cztery";
            case 5: return "pięć";
            case 6: return "sześć";
            default: return "zero";
        }
    }
}

class Program
{

    static void Main()
    {
        Console.WriteLine("Podaj liczbę oczek dla kostki: ");
        kosc Kosc1 = new kosc(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("KOŚĆ 1:");
        Console.WriteLine("Liczba instancji: " + kosc.liczbaInstancji);
        Console.WriteLine("Liczba oczek: " + Kosc1.LiczbaOczek);
        Console.WriteLine("Wartość tekstowo: " + Kosc1.PobierzWartoscTekstowo());
        Console.WriteLine("Nazwa pliku: " + Kosc1.nazwyplikow[Kosc1.index]);
        //Console.WriteLine("Nazwa pliku: " + Kosc1.nazwyplikow[Kosc1.index]);
        Console.WriteLine();

        kosc Kosc2 = new kosc();
        Console.WriteLine("KOŚĆ 2:");
        Console.WriteLine("Liczba instancji: " + kosc.liczbaInstancji);
        Console.WriteLine("Liczba oczek: " + Kosc2.LiczbaOczek);
        Console.WriteLine("Wartość tekstowo: " + Kosc2.PobierzWartoscTekstowo());
        Console.WriteLine("Nazwa pliku: " + Kosc2.nazwyplikow[Kosc2.index]);

        Console.WriteLine();
    }
}
