using AppConsoleLivres;
internal class Program
{
    private static void Main(string[] args)
    {
        Revue FootRevue = new Revue("FootMercato", "Youness Boukouchi", 130, 20, 2025);
        Revue BasketRevue = new Revue("Washington Post", "Archange Tshikaya", 200, 15, 2024);
        Revue CuisineRevue = new Revue("Bonne Cuisine", "Gino Da Campo", 210, 18, 2008);



        FootRevue.AfficherDetail();
        BasketRevue.AfficherDetail();
        CuisineRevue.AfficherDetail();
    }
}