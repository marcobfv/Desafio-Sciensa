# Desafio-Sciensa

REQUISITOS:
- Windows 10;
- Visual Studio 2017;
- NET CORE 2.0;
- Atualizar ferramentas azure Cloud
;
- Atualizar Service Fabric;

- Instalar Service Fabric SDK and tools;
- PowerShell;

- Executar o PowerShell como administrador e rodar o seguinte comando :

Set-ExecutionPolicy -ExecutionPolicy Unrestricted -Force -Scope CurrentUser



INICIANDO PROJETO
- Executar o Visual Studio como Administrador;
- Executar o projeto(F5);
- Aguardar o cluster do Service Fabric iniciar;
- O Projeto WebAPI esta configurado na porta 8080;
- O projeto Web para manipula��o dos dados esta rodando na porta 8855;

Ap�s conclus�o do registro das aplica��es pelo Serice Fabric os seguintes links s�o funcionais:

- Aplica��o WEB:
	http://localhost:8855/
- WebAPI:
	http://localhost:8080/api/cliente
  	http://localhost:8080/api/conta
