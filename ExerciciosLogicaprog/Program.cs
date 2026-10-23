Console.WriteLine("Hello, World!");

// Obrigatórias
// 1.
int distancia = 30 + 16;
int diasSegunda = distancia / 20;
int espera = diasSegunda - 16;
Console.WriteLine($"Exercicio 1: {espera} dias");

// 3.
int sabores = 3;
int bordas = 2;
int tamanhos = 2;
int combinacoes = sabores * bordas * tamanhos;
Console.WriteLine($"Combinações diferentes: {combinacoes}");

Console.WriteLine();
Console.WriteLine("4) Sequências");
Console.WriteLine("I) Próximo número: 9");
Console.WriteLine("II) Próximo número: 128");
Console.WriteLine("III) Próximo número: 49");
Console.WriteLine("IV) Próximo número: 100");
Console.WriteLine("V) Próximo número: 13");
Console.WriteLine("VI) Próximo número: 20");

Console.WriteLine();
Console.WriteLine("Exercícios básicos");

// 1. Dobro de um número
Console.Write("Digite um número inteiro: ");
string input = Console.ReadLine() ?? "0";
int numero = int.Parse(input);
int dobro = numero * 2;
Console.WriteLine($"O dobro de {numero} é {dobro}");

// 2. Soma simples
Console.Write("Digite o primeiro número: ");
string input1 = Console.ReadLine() ?? "0";
Console.Write("Digite o segundo número: ");
string input2 = Console.ReadLine() ?? "0";
int numero1 = int.Parse(input1);
int numero2 = int.Parse(input2);
int soma = numero1 + numero2;
Console.WriteLine($"A soma de {numero1} + {numero2} é {soma}");

// 3. Par ou ímpar
Console.Write("Digite um número inteiro: ");
string input3 = Console.ReadLine() ?? "0";
int num3 = int.Parse(input3);
if (num3 % 2 == 0)
{
    Console.WriteLine($"{num3} é par.");
}
else
{
    Console.WriteLine($"{num3} é ímpar.");
}

// 4. Maior número
Console.Write("Digite o primeiro número: ");
string input4 = Console.ReadLine() ?? "0";
Console.Write("Digite o segundo número: ");
string input5 = Console.ReadLine() ?? "0";
int num4 = int.Parse(input4);
int num5 = int.Parse(input5);
if (num4 > num5)
{
    Console.WriteLine($"{num4} é maior que {num5}.");
}
else if (num5 > num4)
{
    Console.WriteLine($"{num5} é maior que {num4}.");
}
else
{
    Console.WriteLine($"{num4} e {num5} são iguais.");
}

// 5. Idade mínima
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine() ?? "0");
if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}

// 6. Login
Console.Write("Digite o usuário: ");
string usuario = Console.ReadLine() ?? string.Empty;
Console.Write("Digite a senha: ");
string senha = Console.ReadLine() ?? string.Empty;
if (usuario == "admin" && senha == "1234")
{
    Console.WriteLine("Login bem-sucedido!");
}
else
{
    Console.WriteLine("Usuário ou senha incorretos.");
}

// 7. Maior de três números
Console.Write("Digite o primeiro número: ");
int n1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Digite o segundo número: ");
int n2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Digite o terceiro número: ");
int n3 = int.Parse(Console.ReadLine() ?? "0");
int maior = n1;
if (n2 > maior) maior = n2;
if (n3 > maior) maior = n3;
Console.WriteLine($"Maior número: {maior}");

// 8. Ajuste de salário
Console.Write("Digite o salário: ");
double salario = double.Parse(Console.ReadLine() ?? "0");
if (salario > 2000)
{
    salario = salario * 1.10;
}
else
{
    salario = salario * 1.20;
}
Console.WriteLine($"Novo salário: R$ {salario:F2}");

// 9. Ano bissexto
Console.Write("Digite um ano: ");
int ano = int.Parse(Console.ReadLine() ?? "0");
if (ano % 4 == 0)
{
    Console.WriteLine("Ano bissexto pelo critério simplificado.");
}
else
{
    Console.WriteLine("Não é bissexto pelo critério simplificado.");
}

// 10. Acesso com convite
Console.Write("Digite sua idade: ");
int idadeAcesso = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Possui convite? (true/false): ");
bool convite = bool.Parse(Console.ReadLine() ?? "false");
if (idadeAcesso >= 18 && convite)
{
    Console.WriteLine("Acesso permitido!");
}
else
{
    Console.WriteLine("Acesso negado.");
}
