using Microsoft.EntityFrameworkCore;
namespace aula12_TPT{

    public class Aluno : Pessoa{
        public string matricula {get;set;} = string.Empty;
    }
}
