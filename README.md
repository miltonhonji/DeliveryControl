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
   
   $\text{Total Mileage} = \text{FinalMileage} - \text{InitialMileage}$
   
   TotalMileage is a derived value calculated using the initial and final mileage.
   
## Route

Represents a route completed during a workday.
	
### Attributes:
	
	- Id
	- WorkDayId
	- DeparturePoint
	- EstimatedDuration
	- RouteAmount
	- CompensationAmount
	- TotalPackages
	- SucessfulDeliveries
	- UnsuccessfulDeliveries
	
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

## 6. Financial indicators

The system aims to provide indicators for monitoring delivery activies:

