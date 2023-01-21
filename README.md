# Animal Shelter API

#### Animal Shelter application for the creation of an API using MVC for CRUD

#### By [Anton Ch](https://github.com/anton3ch)

## Technologies Used

- C#
- .NET 6.0
- ASP.NET Core
- MVC/API architecture
- Versioning

## Description

Animal Shelter lets users create an API.

## Setup/Installation Requirements

- Clone this repository to your Desktop:
  1. Your computer will need to have GIT installed. If you do not currently have GIT installed, follow [these](https://docs.github.com/en/get-started/quickstart/set-up-git) directions for installing and setting up GIT.
  2. Once GIT is installed, clone this repository by typing following commands in your command line:
     <pre>
     ~ $ cd Desktop
     ~/Desktop $ git clone https://github.com/anton3ch/AnimalShelterApi.Solution.git
     ~/Desktop $ cd AnimalShelterApi.Solution
  </pre>
- Install the [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Create appsettings.json file:
  <pre>
   ~/Desktop/AnimalShelterApi.Solution $ cd AnimalShelterApi
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ touch appsettings.json
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ echo '{
      "Logging": {
        "LogLevel": {
          "Default": "Warning",
          "System": "Information",
          "Microsoft": "Information"
        }
      },
      "AllowedHosts": "*",
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=animalShelter_api;uid=root;pwd=[PASSWORD];"
      }
    }' > appsettings.json
  </pre>
  [PASSWORD] is your password
- Install packages and tools:
  <pre>
  ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet restore
  </pre>
- Run Migration to create a database:
  <pre>
  ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet ef migrations add Initial
  </pre>
- Update Database:
  <pre>
  ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet ef database update
  </pre>
- Build the project:
  <pre>
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet build
  </pre>
- Run the project
  <pre>
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet run
  </pre>
- Access you API by following this link: [http://localhost:5004/api/animals](http://localhost:5004/api/animals) to try this application

## Endpoints

| Endpoints                | Returns                        |
| ------------------------ | ------------------------------ |
| api/animals              | All animals                    |
| api/animals/1            | An animal with id = 1          |
| api/animals?breed=sphinx | Animals filtered by breed      |
| api/animals?name=zoe     | Animals filtered by name       |
| api/animals?minimumAge=5 | Animals filtered by age        |

## Versioning

- To change default version of the API, replace highlighted code in Program.cs with desired version:
  <pre>
  ...
  builder.Services.AddApiVersioning(opt =>
      {
        opt.DefaultApiVersion = new ApiVersion<b><span style="color:red">(2,0)</span></b>;
        opt.ReportApiVersions = true;
        opt.AssumeDefaultVersionWhenUnspecified = true;
      });
  ...
  </pre>
- To add another version of API, add this class in AnimalsController.cs:
  <pre>
  ...
  [ApiVersion("2.0")]
  [Route("api/v{version:apiVersion}/[controller]")]
  public class VersionV2Controller : ControllerBase
  {
    // Code
  }
  ...
  </pre>
- To deprecate previous versions, add "Deprecated = true" for that version's class:
  <pre>
  ...
  [ApiVersion("1.0", <b><span style="color:red">Deprecated = true</span></b>)]
  [Route("api/v{version:apiVersion}/[controller]")]
  public class AnimalsController : ControllerBase
  {
    // Code
  }
  ...
  </pre>

  ## Known Bugs

-

## License

[ISC](https://opensource.org/licenses/ISC)

Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted, provided that the above copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.

Copyright (c) 01/20/2023 Anton Ch