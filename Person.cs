public class Person
{   //Atributos
    private string Name, Birth, Cpf, Tel;
    private int Passport;
    

    //Metodos
    public Person()
    {
        this.Name = "";
        this.Birth = "";
        this.Cpf = "";
        this.Tel = "";
    }
    
    public Person(string nameP, string birthP, string cpfP, string telP, Adress adressP, int passportP)
    {
        this.Name = nameP;
        this.Birth = birthP;
        this.Cpf = cpfP;
        this.Tel = telP;
        this.adress = adressP;
        this.Passport = passportP;
    }

    public string Name
    {
        get{ return name;}
        set{ name = value.ToUpper();}
    }

    public string Birth
    {
        get{ return Birth;}
        set{ Birth = value;}
    }

    public string Cpf
    {
        get{ return Cpf;}
        set{ Cpf = value;}
    }

    public string Tel
    {
        get{ return Tel;}
        set{ Tel = value;}
    }

    public int Passport
    {
        get{ return Passport;}
        set{ Passport = value;}
    }
    

    
}