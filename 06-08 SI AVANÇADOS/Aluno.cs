public class Aluno : Pessoa{
    private string Curso;

    public string Curso{
        get (return Curso;)
        set (curso = value)
    }

    public Aluno(string nome, int idade, string curso){
        : base(nome, idade){
            Curso = curso;
        }   
    }

    public override string ToString() {
    return $"{base.ToString()}, Curso: {Curso}";
}


}