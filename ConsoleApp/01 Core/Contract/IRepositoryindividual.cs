public interface IRepositoryindividual
{
    string Registerindividual(Individualprofile Individuals);
    string Register_individual_custompath(Individualprofile Individuals,string path);
    string GetDefaultStoreindividual();
    void Getcustomaizepathstore(string Storepath);
    


    int createid();

}