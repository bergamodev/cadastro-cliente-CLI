// Desafio - Sistema de cadastro de cliente simples
// -> Adicionar cliente (nome e email), -> Listar todos
// -> Buscar por nome, -> Contar quanto clientes cadastrados

using System;
using System.Collections.Generic;

namespace dasafioIntegrador
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> clientes = new List<string>();
      List<string> emails = new List<string>();
      int totalClientes = 0;

      while (true)
      {
        Console.WriteLine("---------------------------");
        Console.WriteLine("|   CADASTRO DE CLIENTE   |");
        Console.WriteLine("---------------------------");
        Console.WriteLine("|  1. Cadastrar Cliente   |");
        Console.WriteLine("|  2. Listar Clientes     |");
        Console.WriteLine("|  3. Buscar Cliente      |");
        Console.WriteLine("|  4. Ver total de cliente|");
        Console.WriteLine("|  5. SAIR                |");
        Console.WriteLine("---------------------------");
        Console.Write("Opção: ");
        string opc = Console.ReadLine();
        
        //validando a opção digitada pelo usuário
        if(!int.TryParse(opc, out int opcao))
        {
          Console.WriteLine("Opção inválida! Escolha um número correspondente ao menu.");
          continue;
        }

        switch (opcao)
        {
          case 1:
            Console.Clear();
            Console.WriteLine("\n==== 1.Cadastro Cliente ====");
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine().Trim();

            //validando nome que usuário digitou, não aceitar valor em branco
            if (string.IsNullOrWhiteSpace(nome))
            {
              Console.WriteLine("Digite um nome, o nome não pode ser vazio!");
            }

            Console.Write("Digite o email do cliente: ");
            string email = Console.ReadLine().Trim();

            // Verifica se o email digitado é válido, se contém @ e .
            if(!email.Contains("@") || !email.Contains("."))
            {
              Console.WriteLine("Email inválido! Deve conter @ e .");
              continue; // volta ao menu sem realizar o cadastro.
            }

            clientes.Add(nome);
            emails.Add(email);

            Console.WriteLine($"Cliente {nome} cadastrado com sucesso!\n");
          break;

         case 2:
          Console.Clear();
          Console.WriteLine("\n==== 2. Lista de Clientes ====");

          //verifica se a lista de clientes está vazia
          if(clientes.Count == 0)
            {
              Console.WriteLine("Nenhum cliente cadastrado até o momento!");
              return;
            }

          //Percorre a lista clientes, para mostrar clientes cadastrado
          for(int i = 0; i < clientes.Count; i++)
            {
              Console.WriteLine($"{i+1}. {clientes[i].ToUpper()} | email: {emails[i]}");
            }
            Console.WriteLine("---------------------------");
         break;

         case 3:
          Console.Clear();
          Console.WriteLine("==== 3. Busca Cliente ====");
          Console.Write("Digite nome do cliente: ");
          string buscaNome = Console.ReadLine().Trim();

            //verifica se o nome digitado está vazio
            if (string.IsNullOrWhiteSpace(buscaNome))
            {
              Console.WriteLine("Digite um nome para a pesquisa.\nO nome não pode ser vazio!");
            }

            //Criando uma lista com resultados
            List<string> resultado = new List<string>();

            //Percorre a lista de clientes, para buscar o nome
            foreach(string cliente in clientes)
            {
              if (cliente.ToLower().StartsWith(buscaNome.ToLower()))
              {
                resultado.Add(cliente);
              }
              //Exibindo quantos clientes foram encontrados
              Console.WriteLine($"Cliente encontrado: {resultado.Count}");

              //Caso encontre cliente, percorre a lista do resultado e exibe o cliente encontrado
              if(resultado.Count > 0)
              {
                foreach (string clienteEncontrado in resultado)
                {
                  Console.WriteLine($"-> {clienteEncontrado}");
                }
              }
              else
              {
                Console.WriteLine("Nenhum usuário encontrado!");
              }
            }        
         break;

         case 4:
         Console.Clear();
         totalClientes = clientes.Count;
         // verifica se a lista de clientes está vazia
         if(totalClientes == 0)
            {
              Console.WriteLine("Nenhum cliente cadastrado!\nCadastre um usuário.");
            }
            else
            {
             Console.WriteLine("==== 4. TOTAL DE CLIENTES ====");
             Console.WriteLine($"Total de clientes cadastrado: {totalClientes}"); 
            }
         break;

         case 5:
         Console.WriteLine("Encerrando o programa...");
         return;

         default:
          Console.WriteLine("Opção escolhida não disponível, tente novamente!");
         break;
        }
      }
    }
  }
}