# Portland Local Business Lookup API

#### By Helen Lehrer

## Description

A One-To-Many API for a local businesses in Portland, OR. `Business`es may belong to a single `Neighborhood`. Businesses and Neighborhoods have full CRUD functionality. JWT Authentication is implemented.

Features:

* User authentification using JWT
* One-to-Many database relationship
* Use of MySQL for database management
* API routes follow RESTful routing

## Technologies Used

* .NET 5.0.401
* C#
* MySQL
* Entity Framework Core 5.0.0
* Identity 5.0.0

## Setup/Installation Requirements

Enter this command into your terminal to clone the project: 
```bash
$ git clone https://github.com/helen-lehrer/PDX-Local-Businesses-API.Solution
```

Navigate from the root directory of the repo into the production folder `PdxLocalBusinesses`:
```bash
$ cd PdxLocalBusinesses
```

Restore dependencies and tools: 
```bash
$ dotnet restore
```

Compile the code: 
```bash
$ dotnet build
```

---

## Database Import/Configuration:

* Download, install, and configure [MySQL](https://dev.mysql.com/downloads/installer/)

Navigate from the root directory of the repo into the production folder `PdxLocalBusinesses`:
```bash
$ cd PdxLocalBusinesses
```

Create a file called **appsettings.json**: 
```bash
$ touch appsettings.json
```

Add the following code to the **appsettings.json** file: 
```bash
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=portland_local_businesses;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  },
  "JWT": {
    "Key": "secret key",
    "Issuer": "helen_lehrer",
    "Audience": "epicodus"
  }
}
```

* Make sure to insert your MySQL username and password into the  **appsettings.json**  connection string

* Note that uid and pwd may vary depending on your MySql configurations.

Update your local MySQL database:
```bash
$ cd dotnet ef database update
```

---

#### Run: 

Navigate from the root directory of the repo into the folder `PdxLocalBusinesses`:
```bash
$ cd PdxLocalBusinesses
```

Run the application:
```bash
$ dotnet run
```

* The API is hosted on http://localhost:5000/ 

## Authorization:

* Using [Postman](https://www.postman.com/), set up a POST request for the route http://localhost:5000/api/businesses/authenticate

Enter the following into the Body:
```bash
{"Name":"user", "Password": "validate"}
```

* The response will contain a JWT Token. Copy and paste the token into the Auth Section of the Header. Your get requests will now be authorized for 48 hrs, after which you will need to get a new token.

## API Endpoints:

GET requests:

Returns all businesses: http://localhost:5000/api/businesses 

Returns a specific business by ID: http://localhost:5000/api/businesses/{id}

Returns all neighborhoods: http://localhost:5000/api/neighborhoods

Returns a specific neighborhood by ID: http://localhost:5000/api/neighborhoods/{id}

---

POST requests:

Add a new business: http://localhost:5000/api/businesses 

JSON format for adding a new business:
```bash
{
  "name": "{BUSINESS NAME}",
  "description": "{BUSINESS DESCRIPTION}",
  "phoneNumber": "{BUSINESS PHONE NUMBER}",
  "neighborhoodId": {NEIGHBORHOOD ID}
}
```

Add a new neighborhood: http://localhost:5000/api/neighborhoods 

JSON format for adding a new neighborhood:
```bash
{
  "name": "{NEIGHBORHOOD NAME}",
}
```

---

PUT requests:

Edit a neighborhood: http://localhost:5000/api/neighborhoods/{id}

Edit a business: http://localhost:5000/api/businesses/{id}

---

DELETE requests:

Delete a neighborhood: http://localhost:5000/api/neighborhoods/{id}

Delete a business: http://localhost:5000/api/businesses/{id}


## Known Bugs

* none

## License
[![License](https://img.shields.io/badge/License-BSD_3--Clause-blue.svg)](https://opensource.org/licenses/BSD-3-Clause)

&copy; _Copyright 2022 Helen Lehrer_