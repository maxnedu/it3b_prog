class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        list.Add(100);
        list.Add(200);
        list.Add(68);
        list.Add(52);
        list.Add(57);
        list.Add(60);
        list.Add(70);
        list.Add(90);
        list.Add(100);
        list.Add(200);
        list.Add(80);

        int x = Pokuta(list);
        Console.WriteLine(x);
       
    }
    public static int Pokuta(List<int> list)
    {
        const int V = 50;
        int pocet = 0;
        for(int i = 0; i < list.Count; i++)
        {
            if(list[i] > V)
            {
                pocet++;
            }
        }
        if(list.Count > 6 && pocet == list.Count)
        {
            return 6000 * pocet;
        } else if(list.Count > 10)
        {
            return 1000 * pocet;
        }
        return pocet * 500;
    }
    public static void Automat()
    {
        int cena = 0;
        while(cena != 35)
        {
            Console.WriteLine("Zadej cenu");
            cena = int.Parse(Console.ReadLine());
        }
    }
    public static void Trezor()
    {
        const int KOD = 135455;
        for(int i = 0;i < 5; i++)
        {
            int vstup = int.Parse(Console.ReadLine());
            if(vstup == KOD)
            {
                Console.WriteLine("You win");
                break;
            }
        }
    }
    public static bool Objednavka(int[] objednavky)
    {
        foreach(int i in objednavky)
        {
            if(i < 0)
            {
                return false;
            }
        }
        return true; 
    }
}
