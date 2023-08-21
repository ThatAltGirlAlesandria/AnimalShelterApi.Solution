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
  $ dotnet ef migrations add Initial
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

## API

<summary>Endpoints</summary>

<span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/
<br>
<span style="color: green; font-style: italic;">POST</span> /api/
<br>
<span style="color: rgb(3, 132, 252);">GET</span> /api/
<br>
<span style="color: orange; font-style: italic;">PUT</span> /api/
<br>
<span style="color: red; font-style: italic;">DELETE</span> /api/
<br>

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

## **Known Bugs**

- I have not implemented a further exploration yet.

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

