# ConstruSystem

Sistema desktop de Gestão e Vendas para Loja de Materiais de Construção, desenvolvido em C# (Windows Forms) com banco de dados MySQL.

O sistema permite controlar login de usuários, registrar vendas com baixa automática de estoque, gerar relatórios por período e exportar/imprimir esses relatórios.

## Funcionalidades

### Login de usuários
- Autenticação por login e senha
- Opção de mostrar/ocultar senha
- Controle de acesso por tipo de usuário (administrador / usuário)
- Redirecionamento para a tela principal após login

### Tela Principal
- Dashboard com vendas do dia, quantidade de vendas e produtos com estoque baixo
- Relógio atualizado em tempo real (via Timer)
- Exibição do usuário logado
- Menu lateral com acesso às demais telas do sistema

### Tela de Vendas
- Pesquisa de produtos em tempo real (por nome ou código)
- Adição de itens com controle de quantidade, desconto e estoque disponível
- Edição e remoção de itens antes de finalizar a venda
- Cálculo automático de subtotal, desconto e total da venda
- Finalização da venda com:
  - Registro da venda e dos itens no banco de dados
  - Baixa automática no estoque
  - Transação (rollback automático em caso de erro)
  - Exibição do próximo código de venda antes mesmo de finalizar

### Tela de Funcionários
- Cadastro, edição e exclusão de funcionários
- Pesquisa por nome ou código

### Tela de Usuários (acesso restrito a administradores)
- Cadastro, edição e exclusão de usuários do sistema
- Definição do tipo de usuário (administrador / usuário)

### Relatório de Vendas
- Filtro por período (data inicial e final)
- Listagem de vendas com funcionário responsável, subtotal, desconto e total
- Cálculo do total geral do período
- Exportação para Excel (.xlsx) formatada, com:
  - Título e período mesclados e centralizados
  - Cabeçalho destacado
  - Formatação monetária (R$)
  - Bordas e total geral em destaque
- Impressão do relatório com pré-visualização (`PrintPreviewDialog`)

## Tecnologias utilizadas

| Tecnologia | Uso |
|---|---|
| C# / .NET Framework | Linguagem e plataforma principal |
| Windows Forms | Interface gráfica desktop |
| MySQL | Banco de dados relacional |
| MySql.Data (MySqlConnector/MySqlClient) | Conexão e comandos com o banco |
| ClosedXML | Geração de planilhas Excel (.xlsx) |
| System.Drawing.Printing | Impressão de relatórios |

## Estrutura do banco de dados (resumo)

O sistema utiliza as seguintes tabelas:

- **usuarios** — controle de login, nome e tipo de acesso do usuário
- **funcionarios** — responsáveis pelas vendas
- **produtos** — cadastro de produtos, preço e estoque
- **vendas** — cabeçalho de cada venda (data, funcionário, subtotal, desconto, total)
- **itens_venda** — itens vinculados a cada venda (produto, quantidade, preço, desconto, total)

Os scripts de banco de dados ficam na pasta `Database/` do projeto:

| Arquivo | Descrição |
|---|---|
| `Database/criar_banco.sql` | Cria o banco `sistema_vendas` e todas as tabelas (com chaves primárias, estrangeiras e restrições) |
| `Database/inserts_sistema_vendas.sql` | Popula o banco com dados de exemplo (usuários, funcionários, produtos, vendas e itens de venda) para teste imediato do sistema |

## Como executar o projeto

### Pré-requisitos

- Visual Studio (2019 ou superior)
- .NET Framework instalado
- MySQL Server instalado e em execução
- Pacote NuGet `MySql.Data`
- Pacote NuGet `ClosedXML` (para exportação em Excel)

### Passos

1. Clone o repositório:
   ```
   git clone https://github.com/LazaroBitencourt/ConstruSystem.git
   ```

2. Abra o arquivo `ContruSystem.sln` no Visual Studio.

3. Restaure os pacotes NuGet do projeto (clique com o botão direito na solução → **Restore NuGet Packages**).

4. Crie o banco de dados e as tabelas executando o script `Database/criar_banco.sql` no MySQL Workbench (ou outro cliente MySQL de sua preferência):
   ```sql
   SOURCE caminho/para/Database/criar_banco.sql;
   ```

5. (Opcional, mas recomendado) Popule o banco com dados de exemplo para testar o sistema imediatamente, executando `Database/inserts_sistema_vendas.sql`:
   ```sql
   SOURCE caminho/para/Database/inserts_sistema_vendas.sql;
   ```

   O usuário administrador padrão criado pelo script é:
   | Login | Senha | Tipo |
   |---|---|---|
   | `admin` | `admin123` | administrador |

6. Configure a string de conexão no `App.config`:
   ```xml
   <connectionStrings>
     <add name="SistemaVendas"
          connectionString="Server=localhost;Database=sistema_vendas;Uid=seu_usuario;Pwd=sua_senha;"
          providerName="MySql.Data.MySqlClient" />
   </connectionStrings>
   ```

7. Compile e execute o projeto (`F5`).

## Solução de problemas comuns

### Erro ao compilar: "The process cannot access the file ... because it is being used by another process"

Isso acontece quando uma instância anterior do programa ainda está em execução em segundo plano. Finalize o processo antes de compilar novamente:

```
taskkill /F /IM ContruSystem.exe /T
```

Se o erro persistir, limpe os arquivos de build:

```
rmdir /S /Q obj
rmdir /S /Q bin
```

### Erro `Table 'nome_do_banco.usuarios' doesn't exist`

Confirme que o schema selecionado/ativo no MySQL é o `sistema_vendas` (o mesmo criado pelo `criar_banco.sql`), e que a `Database` configurada no `App.config` bate com esse nome.

## Roadmap / Melhorias futuras

- [x] Controle de permissões por tipo de usuário (administrador/usuário)
- [ ] Cadastro completo de produtos e fornecedores pela interface
- [ ] Relatórios adicionais (produtos mais vendidos, estoque baixo)
- [ ] Logo da empresa no cabeçalho dos relatórios exportados/impressos
- [ ] Criptografia de senhas (hash) em vez de texto puro

## Autor

Desenvolvido por **Lázaro Bitencourt**
[github.com/LazaroBitencourt](https://github.com/LazaroBitencourt)


---


