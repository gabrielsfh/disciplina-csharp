using Microsoft.EntityFrameworkCore;
namespace aula12_TPH{

    public class Aluno:Pessoa{
        public string matricula {get;set;} = string.Empty;
    }
}
