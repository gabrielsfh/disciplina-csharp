public class Cliente
{

    private int id;
    private string nome;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    // Constructor
    public Cliente(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Id: {id}, Nome: {nome}";
    }
}
