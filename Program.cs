// Caixa Eletrônico

using System.Collections;

Console.WriteLine("Insira seu nome: ");
Console.WriteLine("Insira o número do cartão: ");
Console.WriteLine("Insira a senha: ");
double valor = 1000;
string Extrato = "";
return2:
return3:
Console.WriteLine("Escolha uma das opções a seguir:");


Console.WriteLine("1-Saque");
Console.WriteLine("2-Depósito");
Console.WriteLine("3-Extrato");
Console.WriteLine("4-Transferência");
Console.WriteLine("5-Verificar saldo ");
string opção = Console.ReadLine();

Console.WriteLine("Valor na conta " + valor);

switch (opção)
{
    case "1":
    return1:
    Console.WriteLine("Insira o valor que deseja sacar: ");
    double valorsaque = double.Parse(Console.ReadLine());
    if(valor >=valorsaque)
    { 
        valor -= valorsaque;
        Console.WriteLine("Saque realizado com sucesso!");
        Console.WriteLine("Valor na conta " + valor);
        Extrato += $"-{valorsaque}\n";
        goto return2;
    }
    else 
    {   
        Console.WriteLine("Saque inválido! Favor Tente outro valor. ");
        goto return1;    
    }
    break;
    case "2":
    Console.WriteLine("Insira o valor que deseja depósitar: ");
    double valordeposito = double.Parse(Console.ReadLine());
    valor += valordeposito;
    Console.WriteLine("Depósito realizado com sucesso!");
    Extrato += $"+{valordeposito}\n";
    Console.WriteLine("valor na conta " + valor);
    goto return3;
    
    break;
    case "3":
    Console.WriteLine($"O extrato é: {Extrato}");
    break;
    case "4":
    Console.WriteLine("");
    break;
    case "5":
    Console.WriteLine("");
    break;

}




















