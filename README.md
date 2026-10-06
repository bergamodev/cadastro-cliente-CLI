# 🚀 Cadastro Cliente CLI

> Aplicação de linha de comando (CLI) desenvolvida em C# para cadastro, listar, buscar e ver total de clientes cadastrados.

Projeto prático desenvolvido como projeto pessoal, para estudo fundamentado na documentação oficial da Microsoft para C# e .NET.
---

## 💻 Sobre o Projeto

O **Cadastro de Cliente CLI** é uma ferramenta para uso via terminal que permite cadastrar, listar, buscar e mostrar o total de clientes cadastrados.

### ✨ Funcionalidades
- **Cadastro Dinâmico:** Adição de novos clientes e email com validação de entradas.
- **Listagem Formatada:** Exibição de clientes e email cadastrados.
- **Busca de Clientes:** Busca de clientes através do primeiro nome, exibe uma lista de clientes encontrado, com validação de entradas.
- **Mostra total de clientes cadastrados:** Mostra o total de clientes cadastrado.
- **Tratamento de Erros:** Validações com `TryParse` no menu, para caso usuário digite errado. Validação no cadastro de clientes no nome e email, para evitar erro de degitação e enviar nome em branco.

---

## 🧠 Conceitos Aplicados

**1. Fundamentos em C#** | Tipos primitivos, variáveis, entrada/saída (`Console`), conversão segura de tipos (`int.TryParse`), casting e operadores aritméticos/lógicos. |

**2. Lógica de Programação** | Estruturas condicionais (`if/else`, `switch`), laços de repetição (`while`, `for`, `foreach`), manipulação de listas dinâmicas (`List<T>`) e indexação. |

---

## 🚀 Como Executar o Projeto

### Pré-requisitos
Antes de começar, você precisará ter instalado em sua máquina:
* [.NET SDK](https://dotnet.microsoft.com/download) (versão 8.0 ou superior)
* [Git](https://git-scm.com/)

### Passo a Passo

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/SEU-USUARIO/cadastro-cliente-CLI.git](https://github.com/SEU-USUARIO/cadastro-cliente-CLI.git)

2. **Acesse a pasta do projeto:**
    ```bash
    cd cadastro-cliente-CLI

3. **Execute a aplicação:**
    ```bash
    dotnet run