// Exercício do site URI "Idades"
// Este programa o usuário ira digitar uma quantidade indeterminada de idades até que seja digitado numero negativo. No final mostra a media de toas as idades.

double Media;
int  Soma, Cont;

int Idade = int.Parse(Console.ReadLine());

Cont = 0;
Soma = 0;
while (Idade >= 0)
{
    Soma = Idade + Soma;
    Cont = Cont + 1;
    
    Idade = int.Parse(Console.ReadLine());
}

Media = (double) Soma / Cont;
Console.WriteLine(Media.ToString("F2"));