# _Local Business API_

#### By _**Patty Otero**_

#### _A practice web api with full CRUD functionality, response pagination and wrapper, and Swagger UI for a local business directory._

## Technologies Used

* _C#_
* _.NET 5.0_
* _ASP.NET Core_ 
* _Swagger_
* _Entity Framework Core_
* _MySQL Workbench_

## Description
_This project was created for Epicodus bootcamp to show proficiency in web APIs._

_This API is designed to allow for users to view, query, find a single entry, update a single entry, or delete entries for a database of local businesses._

## Setup/Installation Requirements

* Clone this repository
* Open your terminal and navigate to the top of this directory
* create a file called appsettings.json within the main project folder
* add the following text to the file inserting your own DATABASE NAME, USER ID, and PASSWORD: 
>{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE NAME HERE];uid=[USER ID HERE];pwd=[PASSWORD HERE];"
  }
}
* Navigate to ~/Business in your terminal.
* Run the following commands:
>dotnet ef database update
>dotnet build
>dotnet watch run
* Once successfully running, you can access the api through your browser, Swagger, Postman or similar applications.

## SWAGGER

## BROWSER

## POSTMAN


## Known Bugs

* _ none _

## License

_MIT_

Copyright (c) _2022_ _Patty Otero_