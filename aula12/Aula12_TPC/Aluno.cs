using Microsoft.EntityFrameworkCore;
namespace aula12_TPC{

    public class Aluno : Pessoa{
        public string matricula {get;set;} = string.Empty;
    }
}
