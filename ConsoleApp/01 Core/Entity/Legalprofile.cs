public class Legalprofile :Profile
{
    public DateTime RegisterDate { get; set; }
    public int Income { get; set; }

    public Legalprofile(string _Name, int _Codemeli, string _Address, ProfilecharacterEnum _caracter,
        DateTime _RegisterDate,int _income)
    {
        base.Name = _Name;
        base.Codemeli = _Codemeli;
        base.Address = _Address;
        base.Profilecharacter = _caracter;
        RegisterDate= _RegisterDate;
        Income = _income;
    }


}
