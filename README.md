Informações para Documentação

Pacotes instalados
•	Install-Package Microsoft.EntityFrameworkCore
•	Install-Package Microsoft.EntityFrameworkCore.Design
•	Install-Package Pomelo.EntityFrameworkCore.MySql

•	Inserir o ‘Builder.Services’  Após o ‘var app = builder.Build(),’ já existente!
o	builder.Services.AddDbContext<Contexto>
(options => options.UseMySql(
"server=localhost; initial catalog=CRUD_Emartim;uid=root;pwd=Mg123456",
Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql")));

Comandos do Migration executados para criação do banco
•	Add-Migration Criacao-Inicial -Context Contexto
•	Update-Database -Context Contexto


