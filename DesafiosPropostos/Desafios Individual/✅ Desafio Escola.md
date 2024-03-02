1. Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

- [x] Criar classe Aluno ✅ 2024-02-29
- [x] Criar classe Professor ✅ 2024-02-29
- [x] Criar classe Disciplina ✅ 2024-02-29
- [x] Classe Aluno: string Nome, int idade, double notas ✅ 2024-02-29
- [x] class Disciplina: string Nome, list Alunos ✅ 2024-02-29
- [x] Classe Professor: string nome, list Disciplinas ✅ 2024-02-29

```C#
class Aluno
{
    public string NomeAluno { get; set; }
    public int IdadeAluno { get; set; }
    public double NotasAluno { get; set; }
}

class Disciplina
{
    public string NomeDisciplina { get; set; }
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();

}

class Professor
{
    public string NomeProfessor { get; set; }
    public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
}

```