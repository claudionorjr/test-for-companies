# Documentação do MVC


## Antes de Executar localmente o MVC

Primeiro passo: 
- Abrir o arquivo `appsettings.json` dentro da pasta `TestForCompanies`
- Editar a linha:
`"TestForCompaniesContext": "server=localhost;userid=root;password=SuaSenha;database=NomeDoBanco"`


Segundo passo:
- Instale o pacote `MySQL provider`
1) Execute o comando especificando a versão 2.1.1:

`Install-Package Pomelo.EntityFrameworkCore.MySql -Version 2.1.1`

2) Ou então instale usando a interface do Visual Studio:

Botão direito no nome do projeto -> Manage NuGet Packages

Na aba Browse, pesquise por: Pomelo.EntityFrameworkCore.MySql

Clique uma vez no resultado Pomelo.EntityFrameworkCore.Mysql e, na janela ao lado, escolha a versão 2.1.1

Clique em Install e conclua a instalação.


Terceiro passo:
- Iniciar a primeira Migration ou criar uma nova:
- Execute os comandos:
1) `Add-Migratioin Initial` ***Obs***: `Inicial` é o nome da Migration, pode ser qualquer um!
2) `Update-Database` Com esse comando, seu banco de dados será criado!


## Sobre o MVC - TestForCompanies

### Enunciado:
Uma listagem de fornecedores/purveyor relacionado a uma empresa/company.

### A empresa/company é composta por:
UF
Nome Fantasia
CNPJ
### O fornecedor/purveyor é composto por:
Empresa
Nome
UF
RG
CPF ou CNPJ
Data/hora de cadastro
Telefone


## Sobre Data/SeedingService.cs

- O projeto tem uma opção para "Auto Popular" o banco de dados.
- pode ser desabilitada comentando ou excluindo as linhas abaixo:
           `_context.Company.AddRange(c1, c2, c3, c4);`
           `_context.Purveyor.AddRange(`
           `     p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15,`
           `     p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30`
           `);`
           `_context.SaveChanges();`
