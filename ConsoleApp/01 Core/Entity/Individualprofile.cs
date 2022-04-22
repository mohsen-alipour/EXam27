public class Individualprofile :Profile
{
    public string Family { get; set; }
    public int Mobile { get; set; }
    public string job { get; set; }
    public DateTime Birthday { get; set; }
    public GenderEnum Gender { get; set; }



    public Individualprofile(string _Name, int _Codemeli, string _Address, ProfilecharacterEnum _caracter
        ,string _family,int _mobile,string _job, DateTime _birthday, GenderEnum _gender)     
    {
        Family = _family;
        Mobile = _mobile;
        job = _job;
        Birthday = _birthday;
        Gender = _gender;
        base.Name = _Name;
        base.Codemeli = _Codemeli;
        base.Address = _Address;    
        base.Profilecharacter= _caracter;
    }

}


