# AnimalShelterApi.Solution

#### _By_ _Alesandria Wild_

## **Technologies Used**


- C#
- .NET 6
- .NET-Core 2.2
- ASP.NET Core MVC
- Entity Framework Core 6
- EFCore Design
- EFCore Migration
- Razor
- Swagger
- MySql
- Visual Studio Code
- GitHub
- HTML
- CSS
- MDN Documents
- Dillinger.io
- learhowtoprogram.com
- Command Line


## **Description**
<hr >

A console app that allows users to search local animal shelters for current adoptee's using API calls.

## **Setup/Installation Requirements**

<details>
<summary> Initial Setup </summary>

- Clone this repository to your local machine.
  ```bash
  $ git clone https://github.com/ThatAltGirlAlesandria/AnimalShelterApi.Solution.git
  ```
- Open VS Code (or your IDE of choice).
- Open the top level directory you just cloned.
</details>

<details>
<summary> Database Setup </summary>

- Use a MySql RDBMS (like MySql Workbench) to import/upload the **\_\_**.sql file and create your database.
- In your AnimalShelter Directory, create a file with the name `appsettings.json` and copy and past the following code into this file:

  <pre><code>{
      "Logging": {
          "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
          }
      },
      "AllowedHosts": "*",
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;animal_shelter;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
      }
  }</code></pre>

- Use your personal UID and Password for your db connection and make sure you remove the brackets currently in place.
</details>

<details>
<summary> Finish Setup </summary>

- In your terminal:

  Change directory (cd) to AnimalShelter.

  ```bash
  $ dotnet build
  ```

  ```bash
  $ dotnet ef database update
  ```

  ```bash
  $ dotnet run
  ```

  (or `dotnet watch run` to see edit and see edits in real time).

- A web page will automatically open in your browser at port 5000 or 5001
</details>


## API Documentation:
<hr >

## Swagger

This project uses [Swashbuckle](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio) to generate Swagger documentation for the API. After building and running the API you can view that documentation by visiting `http://localhost:5000/swagger`.

**Please note** that there are two versions of the API available, and to view the documentation for v2.0 please select it from the drop down list in the top right corner.


## Endpoints
<details>
<summary>Endpoints</summary>
  <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/Animals
  <br>
  <span style="color: green; font-style: italic;">POST</span> /api/Animals
  <br>
  <span style="color: rgb(3, 132, 252);">GET</span> /api/Animals/{id}
  <br>
  <span style="color: orange; font-style: italic;">PUT</span> /api/Animals/{id}
  <br>
  <span style="color: red; font-style: italic;">DELETE</span> /api/Animals/{id}
  <br>
</details>

## HTTP Request Structure
- A good GET request will receive a "200 ok" status. This means that it was a success.
- However, when requesting a POST query you will receive a "201" code to signify it was a success.
-If you receive a 400 or 404 it indicates that the request is bad. Make sure your spelling is correct and written correctly.

## Example Api Query

```
https://localhost:5001/api/Animals
```

## Response Example

```
{
  "AnimalId" : 1,
  "AnimalType" : "Dog",
  "AnimalName" : "Trash",
  "MaleFemale" : "Female",
  "AnimalDescription" : "They were found dumpster diving.",
  "AnimalAge" : 3
}
```

## Debugging

<details>
<summary> If the program does not run...</summary>

- Make sure you have the appropriate packages installed to run dotnet

  - In your Terminal, enter the following commands:<br>
    ```bash
     dotnet tool install --global dotnet-ef --version 6.0.0
    ```
    ```bash
     dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
    ```
    ```bash
     dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
    ```
    ```bash
     dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
    ```
- To overwrite a different version of .NET to .NET 6, Try creating a `global.json` file in the Factory dir that contains the following code to override the default version, if your version exceeds .NET 6.0:<br>
  <pre><code>{
      "sdk": {
          "version": "6.0.402"
      }
  }
  </code></pre>
</details>

## Pagination

As part of the requirements for this project, I had to implement another feature of my choosing after finishing the initial requirements. While I initially attempted versioning, it wasn't working for me so I decided to switch to Pagination.

<details>
  _pageSize={int}_
  - Sets page size for returned values, only applicable to /api/Animals` as it returns a list.
  - Defaults to 10, with a maximum value of 10.
  <br<>
  _pageNumber={int}_
  - Returns the values located in that page.
  - EX: 100 total animals, a pageNumber of 2 will return
  the animals located in rows 11 to 20.
  - Defaults to 1.
</details>

## **Known Bugs**
<hr >

- None know, if any found please contact me at <thataltgirlalesandria@gmail.com>

## License

MIT License

Copyright (c) 2023 ThatAltGirlAlesandria

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

