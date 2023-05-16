# Hackaton Fundacion Esplai: Login & Register

[![CodeFactor](https://www.codefactor.io/repository/github/ismaelbaena/hackaton-fundacionesplai/badge)](https://www.codefactor.io/repository/github/ismaelbaena/hackaton-fundacionesplai)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=IsmaelBaena_Hackaton-FundacionEsplai&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=IsmaelBaena_Hackaton-FundacionEsplai)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=IsmaelBaena_Hackaton-FundacionEsplai&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=IsmaelBaena_Hackaton-FundacionEsplai)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=IsmaelBaena_Hackaton-FundacionEsplai&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=IsmaelBaena_Hackaton-FundacionEsplai)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=IsmaelBaena_Hackaton-FundacionEsplai&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=IsmaelBaena_Hackaton-FundacionEsplai)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=IsmaelBaena_Hackaton-FundacionEsplai&metric=duplicated_lines_density)](https://sonarcloud.io/summary/new_code?id=IsmaelBaena_Hackaton-FundacionEsplai)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=IsmaelBaena_Hackaton-FundacionEsplai&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=IsmaelBaena_Hackaton-FundacionEsplai)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=IsmaelBaena_Hackaton-FundacionEsplai&metric=bugs)](https://sonarcloud.io/summary/new_code?id=IsmaelBaena_Hackaton-FundacionEsplai)


Aplicación [ASP.NET Core](https://dotnet.microsoft.com/en-us/learn/aspnet/what-is-aspnet-core) MVC con [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core) que simula el registro e inicio de sesión de usuarios en una web.

## Installation

1. Clonar o descargar un .ZIP con el código de este repositorio.
2. En caso de no tener node.js descargarlo
3. Ejecutar el siguiente comando en la carpeta del proyecto: 
```shell
    node server.js
```
4. Abrir el proyecto con [Visual Studio](https://visualstudio.microsoft.com) o un IDE similar.
5. Añadir un servicio **SQL Server** con los siguientes campos:
    - Connection String Name: `connectionLocalDb`
    - Connection String Value: `Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true`
6. En la ventana **Package Manager Console**, introducir el siguiente comando: `update-database`
7. Ejecutar.
8. Entrar en la siguiente ruta: `http://localhost:3000/HTML/index.html`
9. Disfrutar de la aplicacion

En caso de problemas de dependencias, se deben instalar los siguientes paquetes NuGet en el proyecto:
- [Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/7.0.5?_src=template)
- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/7.0.5?_src=template)
- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/7.0.5?_src=template)
- [Microsoft.VisualStudio.Web.CodeGeneration.Design](https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design/7.0.6?_src=template)


## Contacto

- [Ismael Baena Mondéjar en **LinkedIn**](https://www.linkedin.com/in/ismael-baena-mondejar)

## License 

[MIT](https://opensource.org/licenses/MIT)