class Sestricka
{
    public string Jmeno {  get; set; }
    private int Plat;
    public Oddeleni Oddeleni { get; set; }

    public Sestricka(string jmeno, int plat)
    {
        Jmeno = jmeno;
        Plat = plat;
        Oddeleni = null;
    }

    public int ZvysPlat(Sestricka sestricka, int pridavek)
    {
        int novyPlat = sestricka.Plat + pridavek;
        return novyPlat;
    }
    public int SnizPlat(Sestricka sestricka, int ubytek)
    {
        int novyPlat = sestricka.Plat - ubytek;
        return novyPlat;
    }
    public void PridejOddelen(Oddeleni oddeleni)
    {

    }

}
class Mistnost
{
    public int Luzko {  get; set; }
    public bool JeObsayeno { get; set; }
    public int Pacient { get; set; }

    public Mistnost(int luzko, int pacient = 0)
    {
        Luzko = luzko;
        JeObsayeno = false;
        Pacient = pacient;
    }
    public int PridejPacienta()
}
class Oddeleni
{
    public List<Mistnost> Mistnost { get; set; }
    public Sestricka Sestricka { get; set; }

    public Oddeleni(List<Mistnost> mistnost, Sestricka sestricka)
    {
        Mistnost = mistnost;
        Sestricka = sestricka;
    }
    public int VolneLuzko(Mistnost mistnost)
    {
       return mistnost.Luzko += 1;
    }
}
