public class Profile
{
    public string Name { get; set; }
    public int Codemeli { get; set; }
    public string Address { get; set; }
    public ProfilecharacterEnum Profilecharacter { get; set; }
    public Profile(string _name, int _codemeli, string _address, ProfilecharacterEnum _character)
    {
        Name = _name;
        Codemeli = _codemeli;
        Address = _address;
        Profilecharacter = _character;
    }

}


