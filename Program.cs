using RevNotas;

Console.WriteLine("Calculando médias");

Notas notas = new Notas(8.5, 1.9, 5.8);

double notaFinal = notas.MediaNotas();

Console.WriteLine($"Notal final: {notaFinal:f2}");

if (notaFinal < 6.0)
{
    Console.WriteLine("Reprovado");
    double pontos = 6.0 - notaFinal;
    Console.WriteLine($"Faltam {pontos:f2} pontos para você ser aprovado");
}else
{
    Console.WriteLine("Parabéns! Aprovado.");
}