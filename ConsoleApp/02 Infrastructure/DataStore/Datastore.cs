public static class Datastore
{
  static string Path_individual = "C:\\Users\\pc\\Desktop\\0202\\individual.txt";
  static string Path_legal = "C:\\Users\\pc\\Desktop\\0202\\legal.txt";
    
   public static string P_individual()
    {
        return Path_individual;
    }
    public static string P_legal()
    {
        return Path_legal;
    }
    public static void StoreindividualsToFile(Individualprofile individuals)
    {
        File.AppendAllLines(Path_individual, individuals);
    }
    public static void Store_custome_individualsToFile(Individualprofile individuals,string p)
    {
        File.AppendAllLines(p, individuals);
    }
    public static void Store_custome_legalsToFile(Legalprofile legals, string p)
    {
        File.AppendAllLines(p, legals);
    }



}
