public class Repositorylegal : IRepositorylegal
{
    
    public string Registerlegal(Legalprofile legals)
    {
        Datastore.StoreToFile(legals);

        return "Register individual is ok";
    }
    public string GetDefaultStorelegal()
    {
        Datastore.P_legal();
        return "OK";
    }
    public string Register_Legal_custompath(Legalprofile legals, string path)
    {
        Datastore.Store_custome_legalsToFile(legals, path);
        return "Register individual is ok";
    }

    public int createid()
    {
        return 0;
    }
}
