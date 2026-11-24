# US English

## 1. About the project

**Delivery Control** is a personal project developed with the goal of creating an application to manage and track deliveries perfomed through Mercado Livre.

The application aims to centralize operational and financial information, allowing users to monitor workdays, routes, deliveries, mileage, expenses, compensations, and financial results.

Initial, the system will use manual data entry without depending on external Mercado Livre API integrations.

## Project Information

| Information | Details                                                                               |
|-------------|---------------------------------------------------------------------------------------|
|Start Date   | October 19, 2026 																	  |
|Status       | In development   																	  |
|Objective    | Develop an application to manage and track deliveries perfomed through Mercado Livre. |

## 2. Project objectives

    - Register workdays.
    - Manage completed routes.
    - Register route departure points.
    - Track traveled mileage.
    - Record successful and unsuccessful deliveries.
    - Track amounts received for routes.
    - Register compensations and deductions.
    - Manage work-related expenses.
    - Calculte financial results.
   
## 3. Domain modelling

The project uses Object-Oriented Programming (OOP) concepts, separating responsibilities through domain entities.

### Main entities

| Entities    | Responsability                    |
|-------------| ----------------------------------|
| BaseEntity  | Base class for entities           |
| WorkDay     | Represents a workday              |
| Route       | Represents a completed route      |
| Expense     | Represents a work-related expense |

### Relationships

    - A WorkDay can have multiple Routes.
    - A WorkDay can have multiple Expenses.
    - A Route belongs to a WorkDay.
   
## 4. Business rules

## WorkDay

Represents the delivery driver's workday.   

### Attributes:

    - Id
    - Date
    - InitialMileage
    - FinalMileage
    - TotalMileage
   
   **Total mileage calculation:**
   
   $\text{TotalMileage} = \text{FinalMileage} - \text{InitialMileage}$
   
   TotalMileage is a derived value calculated using the initial and final mileage.
   
## Route

Represents a route completed during a workday.
	
### Attributes:
	
	- Id
	- WorkDayId
	- DeparturePointId
	- EstimatedDuration
	- RouteAmount
	- DiscountAmount
	- CompensationAmount
	- TotalPackages
	- SucessfulDeliveries
	- UnsuccessfulDeliveries
	
   **Total amount calculation:**   
   
   $\text{TotalAmount} = \text{RouteAmount} + \text{CompensationAmount} - \text{DiscountAmount}$

A route is associated with a workday and a departure point. It can contain multiple individual deliveries.

## DeparturePoint

Represents the departure location of a route, such as a distribution center or agency.

### Attributes:
	- Id 
	- Name
	- AddressId

## Address

Represents an address that can be reused by other domain entities.

### Attributes:
	- Id
	- Street
	- Number
	- Neighborhood
	- City
	- State
	- ZipCode
	
### Expense

Represents expenses related to delivery activies.

It purpose is to record and track operational expenses, allowing the system to calculate financial results.

## 5. Domain sctructure

The entities use an abstract base class:

 ```csharp

public class BaseEntity
{
    public int Id { get; set; }
}

```

Other entities inherit from BaseEntity, reusing the identification property.

## 6. Financial indicators (In planning)

The system aims to provide indicators for monitoring delivery activies:

	- Total amount received from routes.
	- Total compensations.
	- Total deductions.
	- Total expenses.
	- Total mileage traveled.
	- Net financial result.
	
## 7. Technologies

_ In development - to be updated according to implementation _

	- C#
	- .NET
	- Object-Oriented Programming
	- Relational database

## 8. Diagrams

The project model will be documented using UML diagrams, allowing visualization of entities, their attributes, methods, and relationships.
	
## 9. Project status

### In development

Development is being carried out incrementally, prioritizing domain modeling and business rule definitions before implementing the remaing layers.

## 10. Next steps

* (●) In planning - Yes Option.
* ( ) In planning - No Option.

## 11. Development Time

This section tracks the time dedicated to the development of Delivery Control.

Development hours are Currently being recorded in a personal schedule. The accumulated time will be updated as the project progresses.

### Project Information

| **Infomrmation**    | **Details**         |
|---------------------| --------------------|
| Start date          | October 19, 2026    |
| Development hours   | To be calculated    |
| Status              | In development      |
| Last Update         | November 24, 2026   |

### Total Development Time

# 15h 30min

*Total time invested in the development of Delivery Control.*

### Hours by Activy

| **Activy**                  | **Hours**           |
|-----------------------------|---------------------|
| Modeling and Archicture     |     To be calculated|
| Development                 |     To be calculated|
| Database                    |     To be calculated|
| Documentation               |     To be calculated|
| Total         		      |     	   15h 30min|


# BR Português

## 1. Sobre o projeto

O **Delivery Control** é um projeto pessoal desenvolvido com o objetivo de criar uma aplicação para gerenciamento e acompanhmaento das entregas realizadas pelo Mercado Livre.

A aplicação busca centralizar informações operacionais e financeiras, permintindo jornadas de trabalho, rotas, entregas, quilometragem, despesas, compensações e resultados financeiros.

Inicialmente, o sistema utilizará cadastros manuais, sem depender de integrações com APIs externas do Mercado Livre.

## Informações do projeto

| Informações     | Detalhes                                                                                                  |
|-----------------|-----------------------------------------------------------------------------------------------------------|
|Data de Início   | 19/10/2026 																	                              |
|Status           | Em Desenvolvimento  																                      |
|Objetivo         | Desenvolver uma aplicação para gerenciamento e acompanhamento das entregas realizadas pelo Mercado Livre. |

## 2. Objetivos

    - Registrar os dias de trabalho.
    - Controlar as rotas realizadas.
    - Registrar os pontos de partida das rotas.
    - Acompanhar a quilometragem percorrida.
    - Registrar entregas realizadas e não realizadas.
    - Controlar valores recebidos pelas rotas.
    - Registrar descontos e compensações.
    - Controlar despesas relacionadas ao trabalho.
    - Calcular o resultado financeiro das atividades.
   
## 3. Modelagem de domínio

O projeto utiliza coneceitos de Programação Orientada a Objetos (POO), separando as responsabilidades por entidades.

### Entidades principais

| Entidade    | Responsabilidade                                             |
|-------------| -------------------------------------------------------------|
| BaseEntity  | Classe base das entidades                                    |
| WorkDay     | Representa um dia de trabalho                                |
| Route       | Representa uma rota realizada duraten o dia de trabalho      |
| Expense     | Representa uma despesa relacionada do trabalho               |

### Relacionamentos

    - A WorkDay can have multiple Routes.
    - A WorkDay can have multiple Expenses.
    - A Route belongs to a WorkDay.
   
## 4. Business rules

## WorkDay

Represents the delivery driver's workday.   

### Attributes:

    - Id
    - Date
    - InitialMileage
    - FinalMileage
    - TotalMileage
   
   ** Total mileage calculation: **
   
   $\text{TotalMileage} = \text{FinalMileage} - \text{InitialMileage}$
   
   TotalMileage is a derived value calculated using the initial and final mileage.
   
## Route

Represents a route completed during a workday.
	
### Attributes:
	
	- Id
	- WorkDayId
	- DeparturePointId
	- EstimatedDuration
	- RouteAmount
	- DiscountAmount
	- CompensationAmount
	- TotalPackages
	- SucessfulDeliveries
	- UnsuccessfulDeliveries
	
   ** Total amount calculation: **   
   
   $\text{TotalAmount} = \text{RouteAmount} + \text{CompensationAmount} - \text{DiscountAmount}$

A route is associated with a workday and a departure point. It can contain multiple individual deliveries.

## DeparturePoint

Represents the departure location of a route, such as a distribution center or agency.

### Attributes:
	- Id 
	- Name
	- AddressId

## Address

Represents an address that can be reused by other domain entities.

### Attributes:
	- Id
	- Street
	- Number
	- Neighborhood
	- City
	- State
	- ZipCode
	
### Expense

Represents expenses related to delivery activies.

It purpose is to record and track operational expenses, allowing the system to calculate financial results.

## 5. Domain sctructure

The entities use an abstract base class:

 ```csharp

public class BaseEntity
{
    public int Id { get; set; }
}

```

Other entities inherit from BaseEntity, reusing the identification property.

## 6. Financial indicators (In planning)

The system aims to provide indicators for monitoring delivery activies:

	- Total amount received from routes.
	- Total compensations.
	- Total deductions.
	- Total expenses.
	- Total mileage traveled.
	- Net financial result.
	
## 7. Technologies

_ In development - to be updated according to implementation _

	- C#
	- .NET
	- Object-Oriented Programming
	- Relational database

## 8. Diagrams

The project model will be documented using UML diagrams, allowing visualization of entities, their attributes, methods, and relationships.
	
## 9. Project status

### In development

Development is being carried out incrementally, prioritizing domain modeling and business rule definitions before implementing the remaing layers.

## 10. Next steps

* (●) In planning - Yes Option.
* ( ) In planning - No Option.

## 11. Development Time

This section tracks the time dedicated to the development of Delivery Control.

Development hours are Currently being recorded in a personal schedule. The accumulated time will be updated as the project progresses.

### Project Information

| **Infomrmation**    | **Details**         |
|---------------------| --------------------|
| Start date          | October 19, 2026    |
| Development hours   | To be calculated    |
| Status              | In development      |
| Last Update         | November 24, 2026   |

### Total Development Time

# 13h 30min

*Total time invested in the development of Delivery Control.*

### Hours by Activy

| **Activy**                  | **Hours**           |
|-----------------------------|---------------------|
| Modeling and Archicture     |     To be calculated|
| Development                 |     To be calculated|
| Database                    |     To be calculated|
| Documentation               |     To be calculated|
| Total         		      |     	   15h 30min|


