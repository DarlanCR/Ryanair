public class Adress
{   //Atributos
    private string street , district, city, state, country;
    private int number, zipCode;

    //Metodos
    public Adress()
    {
        this.street = "";
        this.district = "";
        this.city = "";
        this.state = "";
        this.country = "";

        this.number = 0;
        this.zipCode = 0;
    }

    public Adress(string streetA, string districtA, string cityA, string stateA, string countryA, int numberA, int zipCodeA)
    {
        this.street = streetA;
        this.district = districtA;
        this.city = cityA;
        this.state = stateA;
        this.country = countryA;
        this.number = numberA;
        this.zipCode = zipCodeA;
    }

    public string Street
    {
        get{ return street;}
        set{ street = value.ToUpper();}
    }

    public string District
    {
        get{ return district;}
        set{ district = value.ToUpper();}
    }

    public string City
    {
        get{ return city;}
        set{ city = value.ToUpper();}
    }

    public string state
    {
        get{ return state;}
        set{ state = value.ToUpper();}
    }

    public string Country
    {
        get{ return country;}
        set{ country = value.ToUpper();}
    }

    public int Number
    {
        get{ return number;}
        set{ number = value;}
    }

    public int ZipCode
    {
        get{ return zipCode;}
        set{ zipCode = value;}
    }

}