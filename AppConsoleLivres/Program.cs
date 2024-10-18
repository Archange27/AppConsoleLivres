using AppConsoleLivres;
internal class Program
{
    private static void Main(string[] args)
    {
       List<Livre> list = new List<Livre>();
        Roman roman1 = new Roman("Le Banquier du diable", "Jean François Bouchard", 284, 978, 2015);
        Roman roman2 = new Roman("un Boy à Pretoria", "Zamenga Batukezanga", 143, 9785, 1990);

        Revue footRevue = new Revue("FootMercato", "Younes Boukouchi", 120, 2023, 5);
        Revue basketRevue = new Revue("WashingtonPost", "Archange Tshikaya", 110, 2022, 8);


        list.Add(roman1);
        list.Add(roman2);
        list.Add(footRevue);
        list.Add(basketRevue);

        Console.WriteLine("Liste de livres : ");
        foreach (Livre livre in list)

        {
            livre.AfficherDetail();  
        }

    }
}