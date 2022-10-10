internal class Persona
{
    public string nome = "";
    public int psw = 0;
    public int id = 0;


    public Persona()
    {

    }
    public Persona(string nome, int psw, int id)
    {
        this.nome = nome;
        this.psw = psw;
        this.id = id;
    }


    public override string ToString()
    {
        return "Nome: " + nome + " Password: " + psw + " ID: " + id;
    }

    public string stampa()
    {
        return "Nome: " + nome + " Password: " + psw;
    }
    public string setNome(string nome)
    {
        this.nome = nome;
        return nome;
    }
    public int setPsw(int psw)
    {
        this.psw = psw;
        return psw;
    }
    public int setId(int id)
    {
        this.id = id;
        return id;
    }
    public int getId()
    {
        return id;
    }
    public string getNome()
    {
        return nome;
    }
    public int getPsw()
    {
        return psw;
    }

}