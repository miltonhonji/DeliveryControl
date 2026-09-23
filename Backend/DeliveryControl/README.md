#DeliveryControl - Backend

##Criando a Camada Domain - Creating the Domain Layer
<br>
dotnet new classlib  -o src/DeliveryControl.Domain

##Criando a Camada Entities - Creating the Entities Layer
<br>
dotnet new classlib  -o src/DeliveryControl.Entities

##Criando a Camada Helpers - Creating the Helpers Layer
<br>
dotnet new classlib  -o src/DeliveryControl.Helpers

##Criando a camada Infra - Creating the Infra Layer
<br>
dotnet new classlib  -o src/DeliveryControl.Infra

##Criando a camada Web Api <br>
#Creating the WebApi Layer (ENG)
<br>
dotnet new webapi -o  src/DeliveryControl.WebApi

##Instalando o Microsoft.EntityFrameworkCore <br>
#Installing the Microsoft.EntityFrameworkCore

1 - src\DeliveryControl.Domain:
<br>
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.12

2 - src\DeliveryControl.Entities:
<br>
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.12

3 - src\DeliveryControl.Helpers
<br>
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.12

4 - src\DeliveryControl.Infra
<br>
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.12

5 - src\DeliveryControl.WebApi
<br>
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.12