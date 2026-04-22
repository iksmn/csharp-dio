using Fundamentos.Models;

/* Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Mao";
pessoa1.Idade = 75;
pessoa1.Apresentar(); */

/* int quantidadeEmEstoque = 10;

int quantidadeCompra = 4;

if(quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda Realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
} */


/* int quantidadeEmEstoque = 13;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}

else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
} */



/* Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":

        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal.");    
        break;
} */

/* if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u"
    )
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é uma vogal.");
}

 */


/* bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada não liberada!");
}



  */


/* bool possuiPresencaMinima = true;
double media = 7.5D;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}
 */


/* bool choveu = false;
bool estaTarde = false;

if(!choveu && !estaTarde)
{
    Console.WriteLine("Vou no batalhão!");
}
else
{
    Console.WriteLine("Vou no batalhão outro dia");
} */

Calculadora calc = new Calculadora();

calc.Somar(10, 31);
calc.Subtrair(10, 49);
calc.Multiplicar(15, 15);
calc.Dividir(2, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
