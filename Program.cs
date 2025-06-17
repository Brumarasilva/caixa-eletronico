﻿// Caixa Eletrônico

using System.Collections; 

// Solicitação inicial de dados do usuário (simulados apenas com mensagens, sem leitura real)
Console.WriteLine("Insira seu nome: ");
Console.WriteLine("Insira o número do cartão: ");
Console.WriteLine("Insira a senha: ");

// Variável que representa o saldo inicial da conta
double valor = 1000;

// Variável usada para armazenar o extrato das operações realizadas
string Extrato = "";

// Labels de retorno (goto) para repetir a escolha de operação
return2:
return3:

// Menu de operações disponíveis para o usuário
Console.WriteLine("Escolha uma das opções a seguir:");
Console.WriteLine("1-Saque");
Console.WriteLine("2-Depósito");
Console.WriteLine("3-Extrato");
Console.WriteLine("4-Transferência");
Console.WriteLine("5-Verificar saldo ");
Console.WriteLine("6-sair ");

// Captura a opção digitada pelo usuário
string opção = Console.ReadLine();

// Mostra o valor atual da conta
Console.WriteLine("Valor na conta " + valor);

// Switch que executa uma ação de acordo com a opção escolhida
switch (opção)
{
    case "1": // Saque
    return1: // Label para tentar outro valor de saque se for inválido
        Console.WriteLine("Insira o valor que deseja sacar: ");
        double valorsaque = double.Parse(Console.ReadLine()); // Lê o valor do saque

        if (valor >= valorsaque) // Verifica se há saldo suficiente
        {
            valor -= valorsaque; // Atualiza o saldo
            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine("Valor na conta " + valor);
            Extrato += $"-{valorsaque}\n"; // Registra a operação no extrato
            goto return2; // Retorna ao menu de opções
        }
        else
        {
            Console.WriteLine("Saque inválido! Favor Tente outro valor. ");
            goto return1; // Volta para digitar um novo valor de saque
        }
        break;

    case "2": // Depósito
        Console.WriteLine("Insira o valor que deseja depósitar: ");
        double valordeposito = double.Parse(Console.ReadLine());
        valor += valordeposito; // Atualiza o saldo
        Console.WriteLine("Depósito realizado com sucesso!");
        Extrato += $"+{valordeposito}\n"; // Registra o depósito no extrato
        Console.WriteLine("valor na conta " + valor);
        goto return3; // Volta ao menu de opções
        break;

    case "3": // Extrato
        Console.WriteLine($"O extrato é: {Extrato}"); // Exibe as movimentações feitas
        goto return2; // Retorna ao menu

    case "4": // Transferência
        Console.WriteLine("Insira o valor que deseja transferir: ");
        double transferencia = double.Parse(Console.ReadLine());
        valor -= transferencia; // Subtrai o valor transferido do saldo (sem validação)
        Console.WriteLine("valor na conta " + valor);
        Extrato += $"-{transferencia}\n"; // Registra no extrato
        goto return2;
        
    case "5": // Verificar saldo
        Console.WriteLine("valor na conta " + valor);
        goto return2;

    case "6": // Sair
        Console.WriteLine("Operação Finalizada com Sucesso! ");
        break;
}
