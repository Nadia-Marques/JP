using System;

int senha;
int senhaD = 1234;
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Informe uma senha para acessar o sistema");
Console.ResetColor();
senha = int.Parse(Console.ReadLine());

while (senha != senhaD)
{
    Console.WriteLine("Senha errada tente novamente!");
}
Console.WriteLine("Acesso Liberado!");
Console.Clear();
int saldo = 0;


bool continuar = true;
while (continuar)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Ver Saldo");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Sacar");
    Console.WriteLine("4. Sair");
    int opcao = int.Parse(Console.ReadLine());
    Console.ResetColor();

    Console.Clear();
    switch (opcao)
    {
        case 1:
            VerSaldo();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            continuar = false;
            Console.WriteLine("Obrigado por utilizar o caixa eletrônico!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
void VerSaldo()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Saldo atual: R${saldo:f2}");
    Console.ResetColor();
}

void Depositar()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Digite o valor a ser depositado:");
    int valor = int.Parse(Console.ReadLine());
    Console.ResetColor();

    if (valor > 0)
    {
        saldo += valor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Depósito de R${valor:f2} realizado com sucesso.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = (ConsoleColor)ConsoleColor.DarkRed;
        Console.WriteLine("Valor inválido para depósito.");
        Console.ResetColor();
    }
}
void Sacar()
{
    Console.ForegroundColor = (ConsoleColor)ConsoleColor.DarkCyan;
    Console.WriteLine("Digite o valor a ser sacado:");
    Console.ResetColor();
    int valor = int.Parse(Console.ReadLine());
    if (valor > 0 && valor <= saldo)
    {
        saldo -= valor;
        Console.ForegroundColor = (ConsoleColor)ConsoleColor.Green;
        Console.WriteLine($"Saque de R${valor:f2} realizado com sucesso.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = (ConsoleColor)ConsoleColor.Red;
        Console.WriteLine("Valor inválido para saque ou saldo insuficiente.");
        Console.ResetColor();
    }
}