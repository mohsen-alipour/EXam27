public class Repositoryindividual : IRepositoryindividual
{
    public string Registerindividual(Individualprofile Individuals)
    {
        if (DateTime.Now<Individuals.Birthday)
        Datastore.StoreindividualsToFile(Individuals);
        return "Register individual is ok";
    }
    public string GetDefaultStoreindividual()
    {
        return Datastore.P_individual();
    }
    public string Register_individual_custompath(Individualprofile Individuals, string path)
    {
        Datastore.Store_custome_individualsToFile(Individuals, path);
        return "Register individual is ok";
    }

    public int createid()
    {
        return 0;
    }
}
