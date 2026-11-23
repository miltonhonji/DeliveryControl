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
| Last Update         | November 23, 2026   |

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
| Total         		      |     	   13h 30min|

# BR Português