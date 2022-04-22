public interface IRepositorylegal
{
    string Registerlegal(Legalprofile legals);
    string GetDefaultStorelegal();
    string Register_Legal_custompath(Legalprofile legals, string path);


    int createid();

}
