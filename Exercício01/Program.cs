using AlunoNota;

Aluno _aluno =  new Aluno();

_aluno.ReceberDados();

Console.Clear();

Console.WriteLine($"Olá, {_aluno.AlunoName}                        RA: {_aluno.AlunoRA}");
Console.WriteLine();

_aluno.CalcularMedia();
_aluno.ImprimirNota();
_aluno.CalcularNotaFinal();

Console.ReadLine();