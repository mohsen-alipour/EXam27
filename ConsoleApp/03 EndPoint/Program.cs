
Repositoryindividual R_individual = new Repositoryindividual();
Repositorylegal R_legal = new Repositorylegal();


Console.WriteLine("1 - Sabt Individual profile");
Console.WriteLine("2 - Sabt Legal profile");
Console.WriteLine("0 - EXIT");

while (true)
{
    Console.Write("Please Select Action :");
    var action = Convert.ToInt32(Console.ReadLine());
    switch (action)
    {
        case 1:
            Register_individual();
            break;
        case 2:
            register_Legal();
            break;

        case 0:
            break;

    }
}

void Register_individual()
{
    Console.WriteLine("Enter Individual Profile");
    Console.WriteLine("enter name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Codemeli");
    int codemeli = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Address");
    string address = Console.ReadLine();
    Console.WriteLine("Enter type character");
    ProfilecharacterEnum character = ProfilecharacterEnum.Realcharacter;
    Console.WriteLine("enter Family");
    string family = Console.ReadLine();
    Console.WriteLine("Enter Mobile");
    int mobile = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Job");
    string job = Console.ReadLine();
    Console.Write("Enter a date (e.g. 10/22/1365):");
    DateTime birthday = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Enter Gender 1 or 2");
    GenderEnum gender = GenderEnum.Female;

    Individualprofile O_individual = new Individualprofile(name, codemeli, address, character, family,
        mobile, job, birthday, gender);

    Console.WriteLine($"Default Store Path is:{R_individual.GetDefaultStoreindividual}");
    Console.WriteLine("Press Y if is ok");
    Console.WriteLine("Press N if is Not and Enter your Path");
    if (Console.ReadKey().Key == ConsoleKey.Y)
    {    
        R_individual.Registerindividual(O_individual);
    }
    else
    {
        Console.WriteLine("Enter yor Path:");
        var path = Console.ReadLine();

        if (File.Exists(path)) R_individual.Register_individual_custompath(O_individual, path);
        else Console.WriteLine("Path is not ok and stor in Defaut Path:");
        
    }
       

}

void register_Legal()
{
    Console.WriteLine("Enter Legal Profile");
    Console.WriteLine("enter name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Codemeli");
    int codemeli = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Address");
    string address = Console.ReadLine();
    Console.WriteLine("Enter type character");
    ProfilecharacterEnum character = ProfilecharacterEnum.Realcharacter;
    Console.WriteLine("enter Date of register");
    DateTime register = DateTime.Now;
    Console.WriteLine("Enter Icome 0 or 1");
    int income = Convert.ToInt32(Console.ReadLine());


    Legalprofile O_Legal = new Legalprofile (name, codemeli, address, character, register,
        income); 

    Console.WriteLine($"Default Store Path is:{R_legal.GetDefaultStorelegal}");
    Console.WriteLine("Press Y if is ok");
    Console.WriteLine("Press N if is Not and Enter your Path");
    if (Console.ReadKey().Key == ConsoleKey.Y)
    {
        R_legal.Registerlegal(O_Legal);
    }
    else
    {
        Console.WriteLine("Enter yor Path:");
        var path = Console.ReadLine();

        if (File.Exists(path)) R_legal.Register_Legal_custompath(O_Legal, path);
        else Console.WriteLine("Path is not ok and stor in Defaut Path:");

    }
}




